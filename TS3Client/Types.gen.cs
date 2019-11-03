// TS3Client - A free TeamSpeak3 client implementation
// Copyright (C) 2017  TS3Client contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.
// <auto-generated />








using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TS3Client
{
	
	[StructLayout(LayoutKind.Sequential, Pack=0)]
	[DebuggerDisplay("{Value, nq}")]
	public readonly partial struct Uid : IEquatable<Uid>
	{
		public static readonly Uid Null = default;
		public static Uid To(string v) => new Uid(v);

		public string Value { get; }
		public Uid(string value) { if (value == null) throw new ArgumentNullException(nameof(value)); Value = value; }
		public static explicit operator Uid(string v) => new Uid(v);
		public static bool operator ==(Uid a, Uid b) => a.Value == b.Value;
		public static bool operator !=(Uid a, Uid b) => a.Value != b.Value;
		public override int GetHashCode() => Value.GetHashCode();
		public override bool Equals(object obj) => obj is Uid c && Value.Equals(c.Value);
		public override string ToString() => Value.ToString();
		
		public bool Equals(Uid other) => Value.Equals(other.Value, StringComparison.Ordinal);
		
	}
	
	[StructLayout(LayoutKind.Sequential, Pack=0)]
	[DebuggerDisplay("{Value, nq}")]
	public readonly partial struct ClientDbId : IFormattable, IEquatable<ClientDbId>
	{
		public static readonly ClientDbId Null = default;
		public static ClientDbId To(ulong v) => new ClientDbId(v);

		public ulong Value { get; }
		public ClientDbId(ulong value) { if (value == null) throw new ArgumentNullException(nameof(value)); Value = value; }
		public static explicit operator ClientDbId(ulong v) => new ClientDbId(v);
		public static bool operator ==(ClientDbId a, ClientDbId b) => a.Value == b.Value;
		public static bool operator !=(ClientDbId a, ClientDbId b) => a.Value != b.Value;
		public override int GetHashCode() => Value.GetHashCode();
		public override bool Equals(object obj) => obj is ClientDbId c && Value.Equals(c.Value);
		public override string ToString() => Value.ToString();
		
		public bool Equals(ClientDbId other) => Value.Equals(other.Value);
		public string ToString(string format, IFormatProvider formatProvider) => Value.ToString(format, formatProvider);
		
	}
	
	[StructLayout(LayoutKind.Sequential, Pack=0)]
	[DebuggerDisplay("{Value, nq}")]
	public readonly partial struct ClientId : IFormattable, IEquatable<ClientId>
	{
		public static readonly ClientId Null = default;
		public static ClientId To(ushort v) => new ClientId(v);

		public ushort Value { get; }
		public ClientId(ushort value) { if (value == null) throw new ArgumentNullException(nameof(value)); Value = value; }
		public static explicit operator ClientId(ushort v) => new ClientId(v);
		public static bool operator ==(ClientId a, ClientId b) => a.Value == b.Value;
		public static bool operator !=(ClientId a, ClientId b) => a.Value != b.Value;
		public override int GetHashCode() => Value.GetHashCode();
		public override bool Equals(object obj) => obj is ClientId c && Value.Equals(c.Value);
		public override string ToString() => Value.ToString();
		
		public bool Equals(ClientId other) => Value.Equals(other.Value);
		public string ToString(string format, IFormatProvider formatProvider) => Value.ToString(format, formatProvider);
		
	}
	
	[StructLayout(LayoutKind.Sequential, Pack=0)]
	[DebuggerDisplay("{Value, nq}")]
	public readonly partial struct ChannelId : IFormattable, IEquatable<ChannelId>
	{
		public static readonly ChannelId Null = default;
		public static ChannelId To(ulong v) => new ChannelId(v);

		public ulong Value { get; }
		public ChannelId(ulong value) { if (value == null) throw new ArgumentNullException(nameof(value)); Value = value; }
		public static explicit operator ChannelId(ulong v) => new ChannelId(v);
		public static bool operator ==(ChannelId a, ChannelId b) => a.Value == b.Value;
		public static bool operator !=(ChannelId a, ChannelId b) => a.Value != b.Value;
		public override int GetHashCode() => Value.GetHashCode();
		public override bool Equals(object obj) => obj is ChannelId c && Value.Equals(c.Value);
		public override string ToString() => Value.ToString();
		
		public bool Equals(ChannelId other) => Value.Equals(other.Value);
		public string ToString(string format, IFormatProvider formatProvider) => Value.ToString(format, formatProvider);
		
	}
	
	[StructLayout(LayoutKind.Sequential, Pack=0)]
	[DebuggerDisplay("{Value, nq}")]
	public readonly partial struct ServerGroupId : IFormattable, IEquatable<ServerGroupId>
	{
		public static readonly ServerGroupId Null = default;
		public static ServerGroupId To(ulong v) => new ServerGroupId(v);

		public ulong Value { get; }
		public ServerGroupId(ulong value) { if (value == null) throw new ArgumentNullException(nameof(value)); Value = value; }
		public static explicit operator ServerGroupId(ulong v) => new ServerGroupId(v);
		public static bool operator ==(ServerGroupId a, ServerGroupId b) => a.Value == b.Value;
		public static bool operator !=(ServerGroupId a, ServerGroupId b) => a.Value != b.Value;
		public override int GetHashCode() => Value.GetHashCode();
		public override bool Equals(object obj) => obj is ServerGroupId c && Value.Equals(c.Value);
		public override string ToString() => Value.ToString();
		
		public bool Equals(ServerGroupId other) => Value.Equals(other.Value);
		public string ToString(string format, IFormatProvider formatProvider) => Value.ToString(format, formatProvider);
		
	}
	
	[StructLayout(LayoutKind.Sequential, Pack=0)]
	[DebuggerDisplay("{Value, nq}")]
	public readonly partial struct ChannelGroupId : IFormattable, IEquatable<ChannelGroupId>
	{
		public static readonly ChannelGroupId Null = default;
		public static ChannelGroupId To(ulong v) => new ChannelGroupId(v);

		public ulong Value { get; }
		public ChannelGroupId(ulong value) { if (value == null) throw new ArgumentNullException(nameof(value)); Value = value; }
		public static explicit operator ChannelGroupId(ulong v) => new ChannelGroupId(v);
		public static bool operator ==(ChannelGroupId a, ChannelGroupId b) => a.Value == b.Value;
		public static bool operator !=(ChannelGroupId a, ChannelGroupId b) => a.Value != b.Value;
		public override int GetHashCode() => Value.GetHashCode();
		public override bool Equals(object obj) => obj is ChannelGroupId c && Value.Equals(c.Value);
		public override string ToString() => Value.ToString();
		
		public bool Equals(ChannelGroupId other) => Value.Equals(other.Value);
		public string ToString(string format, IFormatProvider formatProvider) => Value.ToString(format, formatProvider);
		
	}
	
}