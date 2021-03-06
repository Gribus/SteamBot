//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_base.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
namespace SteamKit2.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgProtoBufHeader")]
  public partial class CMsgProtoBufHeader : global::ProtoBuf.IExtensible
  {
    public CMsgProtoBufHeader() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private int _client_sessionid = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"client_sessionid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(int))]
    public int client_sessionid
    {
      get { return _client_sessionid; }
      set { _client_sessionid = value; }
    }

    private uint _routing_appid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"routing_appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint routing_appid
    {
      get { return _routing_appid; }
      set { _routing_appid = value; }
    }

    private ulong _jobid_source = (ulong)18446744073709551615;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"jobid_source", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue((ulong)18446744073709551615)]
    public ulong jobid_source
    {
      get { return _jobid_source; }
      set { _jobid_source = value; }
    }

    private ulong _jobid_target = (ulong)18446744073709551615;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"jobid_target", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue((ulong)18446744073709551615)]
    public ulong jobid_target
    {
      get { return _jobid_target; }
      set { _jobid_target = value; }
    }

    private string _target_job_name = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"target_job_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string target_job_name
    {
      get { return _target_job_name; }
      set { _target_job_name = value; }
    }

    private int _eresult = (int)2;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"eresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue((int)2)]
    public int eresult
    {
      get { return _eresult; }
      set { _eresult = value; }
    }

    private string _error_message = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"error_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string error_message
    {
      get { return _error_message; }
      set { _error_message = value; }
    }

    private uint _ip = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint ip
    {
      get { return _ip; }
      set { _ip = value; }
    }

    private uint _auth_account_flags = default(uint);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"auth_account_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint auth_account_flags
    {
      get { return _auth_account_flags; }
      set { _auth_account_flags = value; }
    }

    private int _transport_error = (int)1;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"transport_error", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue((int)1)]
    public int transport_error
    {
      get { return _transport_error; }
      set { _transport_error = value; }
    }

    private ulong _messageid = (ulong)18446744073709551615;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"messageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue((ulong)18446744073709551615)]
    public ulong messageid
    {
      get { return _messageid; }
      set { _messageid = value; }
    }

    private uint _publisherid = default(uint);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"publisherid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint publisherid
    {
      get { return _publisherid; }
      set { _publisherid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgMulti")]
  public partial class CMsgMulti : global::ProtoBuf.IExtensible
  {
    public CMsgMulti() {}
    

    private uint _size_unzipped = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"size_unzipped", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint size_unzipped
    {
      get { return _size_unzipped; }
      set { _size_unzipped = value; }
    }

    private byte[] _message_body = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"message_body", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(null)]
    public byte[] message_body
    {
      get { return _message_body; }
      set { _message_body = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgAuthTicket")]
  public partial class CMsgAuthTicket : global::ProtoBuf.IExtensible
  {
    public CMsgAuthTicket() {}
    

    private uint _estate = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"estate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint estate
    {
      get { return _estate; }
      set { _estate = value; }
    }

    private uint _eresult = (uint)2;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"eresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue((uint)2)]
    public uint eresult
    {
      get { return _eresult; }
      set { _eresult = value; }
    }

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private ulong _gameid = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gameid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::ProtoBuf.ProtoDefaultValue(default(ulong))]
    public ulong gameid
    {
      get { return _gameid; }
      set { _gameid = value; }
    }

    private uint _h_steam_pipe = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"h_steam_pipe", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint h_steam_pipe
    {
      get { return _h_steam_pipe; }
      set { _h_steam_pipe = value; }
    }

    private uint _ticket_crc = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ticket_crc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint ticket_crc
    {
      get { return _ticket_crc; }
      set { _ticket_crc = value; }
    }

    private byte[] _ticket = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(null)]
    public byte[] ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCDDBAppDetailCommon")]
  public partial class CCDDBAppDetailCommon : global::ProtoBuf.IExtensible
  {
    public CCDDBAppDetailCommon() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::ProtoBuf.ProtoDefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _icon = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }

    private string _logo = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"logo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string logo
    {
      get { return _logo; }
      set { _logo = value; }
    }

    private string _logo_small = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"logo_small", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string logo_small
    {
      get { return _logo_small; }
      set { _logo_small = value; }
    }

    private bool _tool = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"tool", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool tool
    {
      get { return _tool; }
      set { _tool = value; }
    }

    private bool _demo = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"demo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool demo
    {
      get { return _demo; }
      set { _demo = value; }
    }

    private bool _media = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"media", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool media
    {
      get { return _media; }
      set { _media = value; }
    }

    private bool _community_visible_stats = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"community_visible_stats", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue(default(bool))]
    public bool community_visible_stats
    {
      get { return _community_visible_stats; }
      set { _community_visible_stats = value; }
    }

    private string _friendly_name = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"friendly_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string friendly_name
    {
      get { return _friendly_name; }
      set { _friendly_name = value; }
    }

    private string _propagation = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"propagation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::ProtoBuf.ProtoDefaultValue("")]
    public string propagation
    {
      get { return _propagation; }
      set { _propagation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
#pragma warning restore 1591
