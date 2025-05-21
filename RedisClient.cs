using Renci.SshNet;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisGuiManager
{
    public class RedisClient
    {
        private ConnectionMultiplexer connection = null;
        private ConfigurationOptions config = null;
        private RedisSettings settings = null;

        public SshClient TunnelSsh { get; set; }
        public ForwardedPortLocal Tunnel { get; set; }
        public int DBBlock { get; set; }
        public IDatabase Redis { get; set; }
        public IServer RedisServer { get; set; }
        public RedisSettings Settings
        {
            get
            {
                return settings;
            }
            set
            {
                settings = value;

                config = new ConfigurationOptions()
                {
                    AbortOnConnectFail = true,
                    ConnectTimeout = 5000,
                    EndPoints = { { value.host, value.port } },
                    DefaultDatabase = 0,
                    Password = value.auth
                };
            }
        }

        public RedisClient(RedisSettings settings)
        {
            Settings = settings;
        }

        public void Connect()
        {
            //if (config == null)
            //{
            //    return new OperateResult(false, "\r\nInvalid configuration");
            //}

            ConfigurationOptions temp_config = new ConfigurationOptions()
            {
                AbortOnConnectFail = true,
                ConnectTimeout = 5000,
                EndPoints = { { settings.host, settings.port } },
                DefaultDatabase = 0,
                Password = settings.auth
            };

            string ip_address = settings.host;
            int port = settings.port;
            if (settings.use_tunnel)
            {
                try
                {
                    ConnectionInfo sshConnInfo = null;
                    if (settings.use_ssh_key == false)
                    {
                        sshConnInfo = new PasswordConnectionInfo(settings.ssh_host, settings.ssh_port, settings.ssh_user, settings.ssh_password)
                        {
                            Timeout = TimeSpan.FromSeconds(60)
                        };
                    }
                    else
                    {
                        sshConnInfo = new PrivateKeyConnectionInfo(settings.ssh_host, settings.ssh_user, new PrivateKeyFile(settings.ssh_key))
                        {
                            Timeout = TimeSpan.FromSeconds(60)
                        };
                    }

                    TunnelSsh = new SshClient(sshConnInfo);

                    ip_address = "127.0.0.1";
                    port = Utils.FreeTcpPort();

                    // ssh
                    TunnelSsh.Connect();

                    // tunnel
                    Tunnel = new ForwardedPortLocal(ip_address, (uint)port, settings.host, (uint)settings.port);
                    TunnelSsh.AddForwardedPort(Tunnel);
                    Tunnel.Start();

                    if (Tunnel.IsStarted == false)
                    {
                        return new OperateResult(false, "\r\nTunnel not started");
                    }

                    temp_config = new ConfigurationOptions()
                    {
                        AbortOnConnectFail = true,
                        ConnectTimeout = 60000,
                        SyncTimeout = 60000,
                        AsyncTimeout = 60000,
                        EndPoints = { { ip_address, port } },
                        DefaultDatabase = 0,
                        Password = settings.auth
                    };
                }
                catch (System.Exception ex)
                {
                    throw new RedisConnectionFailedException("\r\nTunnel connection fail", ex);
                }
            }

            try
			{
                connection = ConnectionMultiplexer.Connect(temp_config);
            }
            catch (RedisConnectionException ex)
			{
                throw new RedisConnectionFailedException("\r\nConnection fail", ex);
			}

            RedisServer = connection.GetServer(string.Format("{0}:{1}", ip_address, port));
            Redis = connection.GetDatabase();
        }

        public void Close()
        {
            if (connection != null)
            {
                connection.Close();
            }

            if (Tunnel != null && Tunnel.IsStarted)
            {
                Tunnel.Stop();
            }

            if (TunnelSsh != null && TunnelSsh.IsConnected)
            {
                TunnelSsh.Disconnect();
            }
        }

        public OperateResult SelectDB(int db_num)
        {
            if (connection == null)
            {
                return new OperateResult(false, "Redis not connected");
            }

            Redis = connection.GetDatabase(db_num);
            DBBlock = db_num;

            return new OperateResult(true, "");
        }

        public IDatabase GetDB(int db_num)
        {
            if (connection == null)
            {
                return null;
            }

            return connection.GetDatabase(db_num);
        }
    }
}
