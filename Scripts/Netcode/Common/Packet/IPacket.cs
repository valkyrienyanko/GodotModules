namespace GodotModules.Netcode
{
    public interface IPacket
    {
        void Write(PacketWriter writer);
        void Read(PacketReader reader);
    }
}