using Netfluid.SmtpParser;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Netfluid.Smtp
{
	class SmtpStateMachine
	{
		private class StateTable : IEnumerable
		{
			private readonly SmtpCommandFactory _commandFactory;
			private readonly Dictionary<int, State> _states = new Dictionary<int, State>();
			private State _state;

			internal StateTable(SmtpCommandFactory commandFactory)
			{
				_commandFactory = commandFactory;
			}

            internal void Initialize(int stateId)
			{
				_state = _states[stateId];
			}

            internal void Add(State state)
			{
				_states.Add(state.StateId, state);
			}

            internal bool TryAccept(TokenEnumerator tokenEnumerator, out SmtpCommand command)
			{
				Tuple<State.MakeDelegate, int> tuple;
				if (!_state.Actions.TryGetValue(tokenEnumerator.Peek(0).Text, out tuple))
				{
					string response = string.Format("expected {0}", string.Join("/", _state.Actions.Keys));
					command = _commandFactory.MakeInvalid(SmtpReplyCode.SyntaxError, response);
					return false;
				}
				command = tuple.Item1(tokenEnumerator);
				if (!(command is InvalidCommand))
				{
					_state = _states[tuple.Item2];
					return true;
				}
				return false;
			}

            IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}
		}

        private class State : IEnumerable
		{
			internal delegate SmtpCommand MakeDelegate(TokenEnumerator enumerator);
			internal int StateId
			{
				get;
				private set;
			}
			internal Dictionary<string, Tuple<State.MakeDelegate, int>> Actions
			{
				get;
				private set;
			}
			internal State(int stateId)
			{
				StateId = stateId;
				Actions = new Dictionary<string, Tuple<State.MakeDelegate, int>>(StringComparer.InvariantCultureIgnoreCase);
			}
			internal void Add(string command, State.MakeDelegate tryMake, int? transitionTo = null)
			{
				Actions.Add(command, Tuple.Create<State.MakeDelegate, int>(tryMake, transitionTo ?? StateId));
			}
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw new NotImplementedException();
			}
		}
		private const int Initialized = 0;
		private const int WaitingForMail = 1;
		private const int WaitingForMailSecure = 2;
		private const int WithinTransaction = 3;
		private const int CanAcceptData = 4;
		private readonly StateTable _stateTable;

		internal SmtpStateMachine(SmtpServer server)
		{
            var commandFactory = new SmtpCommandFactory(server);

            _stateTable = new StateTable(commandFactory)
			{
				new State(0)
				{

					{
						"DBUG",
						new State.MakeDelegate(commandFactory.MakeDbug),
						null
					},

					{
						"NOOP",
						new State.MakeDelegate(commandFactory.MakeNoop),
						null
					},

					{
						"RSET",
						new State.MakeDelegate(commandFactory.MakeRset),
						null
					},

					{
						"QUIT",
						new State.MakeDelegate(commandFactory.MakeQuit),
						null
					},

					{
						"HELO",
						new State.MakeDelegate(commandFactory.MakeHelo),
						new int?(1)
					},

					{
						"EHLO",
						new State.MakeDelegate(commandFactory.MakeEhlo),
						new int?(1)
					}
				},
				new State(1)
				{

					{
						"DBUG",
						new State.MakeDelegate(commandFactory.MakeDbug),
						null
					},

					{
						"NOOP",
						new State.MakeDelegate(commandFactory.MakeNoop),
						null
					},

					{
						"RSET",
						new State.MakeDelegate(commandFactory.MakeRset),
						null
					},

					{
						"QUIT",
						new State.MakeDelegate(commandFactory.MakeQuit),
						null
					},

					{
						"HELO",
						new State.MakeDelegate(commandFactory.MakeHelo),
						new int?(1)
					},

					{
						"EHLO",
						new State.MakeDelegate(commandFactory.MakeEhlo),
						new int?(1)
					},

					{
						"MAIL",
						new State.MakeDelegate(commandFactory.MakeMail),
						new int?(3)
					},

					{
						"STARTTLS",
						new State.MakeDelegate(commandFactory.MakeStartTls),
						new int?(2)
					}
				},
				new State(2)
				{

					{
						"DBUG",
						new State.MakeDelegate(commandFactory.MakeDbug),
						null
					},

					{
						"NOOP",
						new State.MakeDelegate(commandFactory.MakeNoop),
						null
					},

					{
						"RSET",
						new State.MakeDelegate(commandFactory.MakeRset),
						null
					},

					{
						"QUIT",
						new State.MakeDelegate(commandFactory.MakeQuit),
						null
					},

					{
						"AUTH",
						new State.MakeDelegate(commandFactory.MakeAuth),
						null
					},

					{
						"HELO",
						new State.MakeDelegate(commandFactory.MakeHelo),
						new int?(2)
					},

					{
						"EHLO",
						new State.MakeDelegate(commandFactory.MakeEhlo),
						new int?(2)
					},

					{
						"MAIL",
						new State.MakeDelegate(commandFactory.MakeMail),
						new int?(3)
					}
				},
				new State(3)
				{

					{
						"DBUG",
						new State.MakeDelegate(commandFactory.MakeDbug),
						null
					},

					{
						"NOOP",
						new State.MakeDelegate(commandFactory.MakeNoop),
						null
					},

					{
						"RSET",
						new State.MakeDelegate(commandFactory.MakeRset),
						null
					},

					{
						"QUIT",
						new State.MakeDelegate(commandFactory.MakeQuit),
						null
					},

					{
						"RCPT",
						new State.MakeDelegate(commandFactory.MakeRcpt),
						new int?(4)
					}
				},
				new State(4)
				{

					{
						"DBUG",
						new State.MakeDelegate(commandFactory.MakeDbug),
						null
					},

					{
						"NOOP",
						new State.MakeDelegate(commandFactory.MakeNoop),
						null
					},

					{
						"RSET",
						new State.MakeDelegate(commandFactory.MakeRset),
						null
					},

					{
						"QUIT",
						new State.MakeDelegate(commandFactory.MakeQuit),
						null
					},

					{
						"RCPT",
						new State.MakeDelegate(commandFactory.MakeRcpt),
						null
					},

					{
						"DATA",
						new State.MakeDelegate(commandFactory.MakeData),
						new int?(1)
					}
				}
			};
			_stateTable.Initialize(0);
		}
		internal bool TryAccept(TokenEnumerator tokenEnumerator, out SmtpCommand command)
		{
			return _stateTable.TryAccept(tokenEnumerator, out command);
		}
	}
}
