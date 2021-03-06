using System;

namespace Waser.IO
{
	public enum SocketError
	{
		AddressFamilyNotSupported,
		TooManyOpenSockets,
		ProtocolNotSupported,
		ProtocolType,
		OperationNotSupported,
		NotConnected,
		AddressAlreadyInUse,
		AddressNotAvailable,
		IsConnected,
		ConnectionReset,
		NetworkDown,
		HostUnreachable,
		NetworkUnreachable,
		AlreadyInProgress,
		ConnectionRefused,
		TimedOut,
		
		Failure
	}
}

