using FacadeDesignPattern;

var network = new NetworkFacade("127.0.0.1", "https");

network.SendPacketOverNetwork();