namespace FacadeDesignPattern;

public class NetworkFacade
{
    private Packet packet;
    private Socket socket;
    private Transmission transmission;

    public NetworkFacade(string ip, string protocol)
    {
        this.packet = new Packet(ip);
        this.socket = new Socket(protocol);
        this.transmission = new Transmission(protocol);
    }

    private void BuildNetworkLayer()
    {
        packet.BuildPacket();
        socket.BuildSocket();
    }

    public void SendPacketOverNetwork()
    {
        BuildNetworkLayer();
        transmission.SendTransmission();
    }
}