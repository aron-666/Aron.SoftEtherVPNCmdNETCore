using Aron.GrassMiner.Jobs;
using SoftEtherVPNCmdNETCore.VPNClient;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            string vpnName = "test";
            VpnClient vpnClient = new VpnClient(@"C:\Program Files\SoftEther VPN Client\vpncmd.exe");

            await vpnClient.AccountCreate(vpnName, "host:1194", "server", "hub", "VPN5");
            await vpnClient.AccountPasswordSet(vpnName, "", AuthenticationType.Standard);
            await vpnClient.AccountConnect(vpnName);

            Assert.Pass();
        }


    }
}