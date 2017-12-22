// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Service {
  public static partial class StandardInput
  {
    static readonly string __ServiceName = "service.StandardInput";

    static readonly grpc::Marshaller<global::Service.Key> __Marshaller_Key = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Key.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.Response> __Marshaller_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Response.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.MouseCoords> __Marshaller_MouseCoords = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.MouseCoords.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.Connection> __Marshaller_Connection = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Connection.Parser.ParseFrom);

    static readonly grpc::Method<global::Service.Key, global::Service.Response> __Method_PressKey = new grpc::Method<global::Service.Key, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "PressKey",
        __Marshaller_Key,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.MouseCoords, global::Service.Response> __Method_MoveMouse = new grpc::Method<global::Service.MouseCoords, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "MoveMouse",
        __Marshaller_MouseCoords,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.Connection, global::Service.Response> __Method_ClientConnected = new grpc::Method<global::Service.Connection, global::Service.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ClientConnected",
        __Marshaller_Connection,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.Connection, global::Service.Response> __Method_DisconnectClient = new grpc::Method<global::Service.Connection, global::Service.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DisconnectClient",
        __Marshaller_Connection,
        __Marshaller_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Service.ServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StandardInput</summary>
    public abstract partial class StandardInputBase
    {
      public virtual global::System.Threading.Tasks.Task PressKey(grpc::IAsyncStreamReader<global::Service.Key> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task MoveMouse(grpc::IAsyncStreamReader<global::Service.MouseCoords> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Service.Response> ClientConnected(global::Service.Connection request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Service.Response> DisconnectClient(global::Service.Connection request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for StandardInput</summary>
    public partial class StandardInputClient : grpc::ClientBase<StandardInputClient>
    {
      /// <summary>Creates a new client for StandardInput</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StandardInputClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StandardInput that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StandardInputClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StandardInputClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StandardInputClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Service.Key, global::Service.Response> PressKey(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PressKey(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.Key, global::Service.Response> PressKey(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_PressKey, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.MouseCoords, global::Service.Response> MoveMouse(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MoveMouse(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.MouseCoords, global::Service.Response> MoveMouse(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_MoveMouse, null, options);
      }
      public virtual global::Service.Response ClientConnected(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientConnected(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Service.Response ClientConnected(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ClientConnected, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> ClientConnectedAsync(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientConnectedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> ClientConnectedAsync(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ClientConnected, null, options, request);
      }
      public virtual global::Service.Response DisconnectClient(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DisconnectClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Service.Response DisconnectClient(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DisconnectClient, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> DisconnectClientAsync(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DisconnectClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> DisconnectClientAsync(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DisconnectClient, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StandardInputClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StandardInputClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StandardInputBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PressKey, serviceImpl.PressKey)
          .AddMethod(__Method_MoveMouse, serviceImpl.MoveMouse)
          .AddMethod(__Method_ClientConnected, serviceImpl.ClientConnected)
          .AddMethod(__Method_DisconnectClient, serviceImpl.DisconnectClient).Build();
    }

  }
  public static partial class XboxButtons
  {
    static readonly string __ServiceName = "service.XboxButtons";

    static readonly grpc::Marshaller<global::Service.XboxButton> __Marshaller_XboxButton = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.XboxButton.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.Response> __Marshaller_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Response.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.XboxTrigger> __Marshaller_XboxTrigger = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.XboxTrigger.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.XboxThumbAxis> __Marshaller_XboxThumbAxis = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.XboxThumbAxis.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.Connection> __Marshaller_Connection = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Connection.Parser.ParseFrom);

    static readonly grpc::Method<global::Service.XboxButton, global::Service.Response> __Method_PressXboxButton = new grpc::Method<global::Service.XboxButton, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "PressXboxButton",
        __Marshaller_XboxButton,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.XboxButton, global::Service.Response> __Method_DepressXboxButton = new grpc::Method<global::Service.XboxButton, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DepressXboxButton",
        __Marshaller_XboxButton,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.XboxTrigger, global::Service.Response> __Method_XboxLeftTrigger = new grpc::Method<global::Service.XboxTrigger, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "XboxLeftTrigger",
        __Marshaller_XboxTrigger,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.XboxTrigger, global::Service.Response> __Method_XboxRightTrigger = new grpc::Method<global::Service.XboxTrigger, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "XboxRightTrigger",
        __Marshaller_XboxTrigger,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.XboxThumbAxis, global::Service.Response> __Method_XboxLeftThumbAxis = new grpc::Method<global::Service.XboxThumbAxis, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "XboxLeftThumbAxis",
        __Marshaller_XboxThumbAxis,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.XboxThumbAxis, global::Service.Response> __Method_XboxRightThumbAxis = new grpc::Method<global::Service.XboxThumbAxis, global::Service.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "XboxRightThumbAxis",
        __Marshaller_XboxThumbAxis,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.Connection, global::Service.Response> __Method_ClientConnected = new grpc::Method<global::Service.Connection, global::Service.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ClientConnected",
        __Marshaller_Connection,
        __Marshaller_Response);

    static readonly grpc::Method<global::Service.Connection, global::Service.Response> __Method_DisconnectClient = new grpc::Method<global::Service.Connection, global::Service.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DisconnectClient",
        __Marshaller_Connection,
        __Marshaller_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Service.ServicesReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of XboxButtons</summary>
    public abstract partial class XboxButtonsBase
    {
      public virtual global::System.Threading.Tasks.Task PressXboxButton(grpc::IAsyncStreamReader<global::Service.XboxButton> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task DepressXboxButton(grpc::IAsyncStreamReader<global::Service.XboxButton> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task XboxLeftTrigger(grpc::IAsyncStreamReader<global::Service.XboxTrigger> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task XboxRightTrigger(grpc::IAsyncStreamReader<global::Service.XboxTrigger> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task XboxLeftThumbAxis(grpc::IAsyncStreamReader<global::Service.XboxThumbAxis> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task XboxRightThumbAxis(grpc::IAsyncStreamReader<global::Service.XboxThumbAxis> requestStream, grpc::IServerStreamWriter<global::Service.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Service.Response> ClientConnected(global::Service.Connection request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Service.Response> DisconnectClient(global::Service.Connection request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for XboxButtons</summary>
    public partial class XboxButtonsClient : grpc::ClientBase<XboxButtonsClient>
    {
      /// <summary>Creates a new client for XboxButtons</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public XboxButtonsClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for XboxButtons that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public XboxButtonsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected XboxButtonsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected XboxButtonsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxButton, global::Service.Response> PressXboxButton(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PressXboxButton(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxButton, global::Service.Response> PressXboxButton(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_PressXboxButton, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxButton, global::Service.Response> DepressXboxButton(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DepressXboxButton(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxButton, global::Service.Response> DepressXboxButton(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DepressXboxButton, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxTrigger, global::Service.Response> XboxLeftTrigger(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return XboxLeftTrigger(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxTrigger, global::Service.Response> XboxLeftTrigger(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_XboxLeftTrigger, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxTrigger, global::Service.Response> XboxRightTrigger(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return XboxRightTrigger(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxTrigger, global::Service.Response> XboxRightTrigger(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_XboxRightTrigger, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxThumbAxis, global::Service.Response> XboxLeftThumbAxis(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return XboxLeftThumbAxis(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxThumbAxis, global::Service.Response> XboxLeftThumbAxis(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_XboxLeftThumbAxis, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxThumbAxis, global::Service.Response> XboxRightThumbAxis(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return XboxRightThumbAxis(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Service.XboxThumbAxis, global::Service.Response> XboxRightThumbAxis(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_XboxRightThumbAxis, null, options);
      }
      public virtual global::Service.Response ClientConnected(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientConnected(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Service.Response ClientConnected(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ClientConnected, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> ClientConnectedAsync(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientConnectedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> ClientConnectedAsync(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ClientConnected, null, options, request);
      }
      public virtual global::Service.Response DisconnectClient(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DisconnectClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Service.Response DisconnectClient(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DisconnectClient, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> DisconnectClientAsync(global::Service.Connection request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DisconnectClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Response> DisconnectClientAsync(global::Service.Connection request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DisconnectClient, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override XboxButtonsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new XboxButtonsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(XboxButtonsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PressXboxButton, serviceImpl.PressXboxButton)
          .AddMethod(__Method_DepressXboxButton, serviceImpl.DepressXboxButton)
          .AddMethod(__Method_XboxLeftTrigger, serviceImpl.XboxLeftTrigger)
          .AddMethod(__Method_XboxRightTrigger, serviceImpl.XboxRightTrigger)
          .AddMethod(__Method_XboxLeftThumbAxis, serviceImpl.XboxLeftThumbAxis)
          .AddMethod(__Method_XboxRightThumbAxis, serviceImpl.XboxRightThumbAxis)
          .AddMethod(__Method_ClientConnected, serviceImpl.ClientConnected)
          .AddMethod(__Method_DisconnectClient, serviceImpl.DisconnectClient).Build();
    }

  }
}
#endregion
