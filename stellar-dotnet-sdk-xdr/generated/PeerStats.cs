// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  struct PeerStats
//  {
//      NodeID id;
//      string versionStr<100>;
//      uint64 messagesRead;
//      uint64 messagesWritten;
//      uint64 bytesRead;
//      uint64 bytesWritten;
//      uint64 secondsConnected;
//  
//      uint64 uniqueFloodBytesRecv;
//      uint64 duplicateFloodBytesRecv;
//      uint64 uniqueFetchBytesRecv;
//      uint64 duplicateFetchBytesRecv;
//  
//      uint64 uniqueFloodMessageRecv;
//      uint64 duplicateFloodMessageRecv;
//      uint64 uniqueFetchMessageRecv;
//      uint64 duplicateFetchMessageRecv;
//  };

//  ===========================================================================
public class PeerStats
{
    public NodeID Id { get; set; }
    public string VersionStr { get; set; }
    public Uint64 MessagesRead { get; set; }
    public Uint64 MessagesWritten { get; set; }
    public Uint64 BytesRead { get; set; }
    public Uint64 BytesWritten { get; set; }
    public Uint64 SecondsConnected { get; set; }
    public Uint64 UniqueFloodBytesRecv { get; set; }
    public Uint64 DuplicateFloodBytesRecv { get; set; }
    public Uint64 UniqueFetchBytesRecv { get; set; }
    public Uint64 DuplicateFetchBytesRecv { get; set; }
    public Uint64 UniqueFloodMessageRecv { get; set; }
    public Uint64 DuplicateFloodMessageRecv { get; set; }
    public Uint64 UniqueFetchMessageRecv { get; set; }
    public Uint64 DuplicateFetchMessageRecv { get; set; }

    public static void Encode(XdrDataOutputStream stream, PeerStats encodedPeerStats)
    {
        NodeID.Encode(stream, encodedPeerStats.Id);
        stream.WriteString(encodedPeerStats.VersionStr);
        Uint64.Encode(stream, encodedPeerStats.MessagesRead);
        Uint64.Encode(stream, encodedPeerStats.MessagesWritten);
        Uint64.Encode(stream, encodedPeerStats.BytesRead);
        Uint64.Encode(stream, encodedPeerStats.BytesWritten);
        Uint64.Encode(stream, encodedPeerStats.SecondsConnected);
        Uint64.Encode(stream, encodedPeerStats.UniqueFloodBytesRecv);
        Uint64.Encode(stream, encodedPeerStats.DuplicateFloodBytesRecv);
        Uint64.Encode(stream, encodedPeerStats.UniqueFetchBytesRecv);
        Uint64.Encode(stream, encodedPeerStats.DuplicateFetchBytesRecv);
        Uint64.Encode(stream, encodedPeerStats.UniqueFloodMessageRecv);
        Uint64.Encode(stream, encodedPeerStats.DuplicateFloodMessageRecv);
        Uint64.Encode(stream, encodedPeerStats.UniqueFetchMessageRecv);
        Uint64.Encode(stream, encodedPeerStats.DuplicateFetchMessageRecv);
    }

    public static PeerStats Decode(XdrDataInputStream stream)
    {
        var decodedPeerStats = new PeerStats();
        decodedPeerStats.Id = NodeID.Decode(stream);
        decodedPeerStats.VersionStr = stream.ReadString();
        decodedPeerStats.MessagesRead = Uint64.Decode(stream);
        decodedPeerStats.MessagesWritten = Uint64.Decode(stream);
        decodedPeerStats.BytesRead = Uint64.Decode(stream);
        decodedPeerStats.BytesWritten = Uint64.Decode(stream);
        decodedPeerStats.SecondsConnected = Uint64.Decode(stream);
        decodedPeerStats.UniqueFloodBytesRecv = Uint64.Decode(stream);
        decodedPeerStats.DuplicateFloodBytesRecv = Uint64.Decode(stream);
        decodedPeerStats.UniqueFetchBytesRecv = Uint64.Decode(stream);
        decodedPeerStats.DuplicateFetchBytesRecv = Uint64.Decode(stream);
        decodedPeerStats.UniqueFloodMessageRecv = Uint64.Decode(stream);
        decodedPeerStats.DuplicateFloodMessageRecv = Uint64.Decode(stream);
        decodedPeerStats.UniqueFetchMessageRecv = Uint64.Decode(stream);
        decodedPeerStats.DuplicateFetchMessageRecv = Uint64.Decode(stream);
        return decodedPeerStats;
    }
}