using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Netfluid.Smtp
{
    class NetworkTextStream : IDisposable
	{
		private readonly Stream _stream;
		private readonly StreamReader _reader;
		private readonly StreamWriter _writer;

		internal bool IsSecure
		{
			get
			{
				return _stream is SslStream;
			}
		}

        internal NetworkTextStream(TcpClient client) : this(client.GetStream())
		{
		}

        internal NetworkTextStream(Stream stream)
		{
			_stream = stream;
			_reader = new StreamReader(stream, Encoding.ASCII);
			_writer = new StreamWriter(stream, Encoding.ASCII);
		}

        internal Stream GetInnerStream()
		{
			return _stream;
		}

        internal async Task<string> ReadLineAsync(CancellationToken cancellationToken)
        {
            string result;
            try
            {
                result = await _reader.ReadLineAsync().WithCancellation(cancellationToken);
            }
            catch (OperationCanceledException)
            {
                result = null;
            }
            return result;
        }

        internal async Task WriteLineAsync(string text, CancellationToken cancellationToken)
        {
            try
            {
                await _writer.WriteLineAsync(text).WithCancellation(cancellationToken);
            }
            catch (OperationCanceledException)
            {
            }
        }

        internal async Task FlushAsync(CancellationToken cancellationToken)
        {
            try
            {
                await _writer.FlushAsync().WithCancellation(cancellationToken);
            }
            catch (OperationCanceledException)
            {
            }
        }

        internal async Task ReplyAsync(SmtpResponse response, CancellationToken cancellationToken)
        {
            await WriteLineAsync(string.Format("{0} {1}", (int)response.ReplyCode, response.Message), cancellationToken);
            await FlushAsync(cancellationToken);
        }

        public void Dispose()
		{
			_reader.Dispose();
			_writer.Dispose();
			_stream.Dispose();
		}
	}
}
