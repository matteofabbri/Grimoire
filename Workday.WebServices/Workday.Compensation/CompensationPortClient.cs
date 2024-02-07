using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class CompensationPortClient : ClientBase<CompensationPort>, CompensationPort
	{
		public CompensationPortClient()
		{
		}

		public CompensationPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public CompensationPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public CompensationPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public CompensationPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Previous_System_Compensation_HistoryOutput CompensationPort.Put_Previous_System_Compensation_History(Put_Previous_System_Compensation_HistoryInput request)
		{
			return base.Channel.Put_Previous_System_Compensation_History(request);
		}

		public Put_Previous_System_Compensation_History_ResponseType Put_Previous_System_Compensation_History(Workday_Common_HeaderType Workday_Common_Header, Put_Previous_System_Compensation_History_RequestType Put_Previous_System_Compensation_History_Request)
		{
			return ((CompensationPort)this).Put_Previous_System_Compensation_History(new Put_Previous_System_Compensation_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Previous_System_Compensation_History_Request = Put_Previous_System_Compensation_History_Request
			}).Put_Previous_System_Compensation_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Previous_System_Compensation_HistoryOutput> CompensationPort.Put_Previous_System_Compensation_HistoryAsync(Put_Previous_System_Compensation_HistoryInput request)
		{
			return base.Channel.Put_Previous_System_Compensation_HistoryAsync(request);
		}

		public Task<Put_Previous_System_Compensation_HistoryOutput> Put_Previous_System_Compensation_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Previous_System_Compensation_History_RequestType Put_Previous_System_Compensation_History_Request)
		{
			return ((CompensationPort)this).Put_Previous_System_Compensation_HistoryAsync(new Put_Previous_System_Compensation_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Previous_System_Compensation_History_Request = Put_Previous_System_Compensation_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Previous_System_Compensation_HistoryOutput CompensationPort.Get_Previous_System_Compensation_History(Get_Previous_System_Compensation_HistoryInput request)
		{
			return base.Channel.Get_Previous_System_Compensation_History(request);
		}

		public Get_Previous_System_Compensation_History_ResponseType Get_Previous_System_Compensation_History(Workday_Common_HeaderType Workday_Common_Header, Get_Previous_System_Compensation_History_RequestType Get_Previous_System_Compensation_History_Request)
		{
			return ((CompensationPort)this).Get_Previous_System_Compensation_History(new Get_Previous_System_Compensation_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Previous_System_Compensation_History_Request = Get_Previous_System_Compensation_History_Request
			}).Get_Previous_System_Compensation_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Previous_System_Compensation_HistoryOutput> CompensationPort.Get_Previous_System_Compensation_HistoryAsync(Get_Previous_System_Compensation_HistoryInput request)
		{
			return base.Channel.Get_Previous_System_Compensation_HistoryAsync(request);
		}

		public Task<Get_Previous_System_Compensation_HistoryOutput> Get_Previous_System_Compensation_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Previous_System_Compensation_History_RequestType Get_Previous_System_Compensation_History_Request)
		{
			return ((CompensationPort)this).Get_Previous_System_Compensation_HistoryAsync(new Get_Previous_System_Compensation_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Previous_System_Compensation_History_Request = Get_Previous_System_Compensation_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Request_Bonus_PaymentOutput CompensationPort.Request_Bonus_Payment(Request_Bonus_PaymentInput request)
		{
			return base.Channel.Request_Bonus_Payment(request);
		}

		public Request_Bonus_Payment_ResponseType Request_Bonus_Payment(Workday_Common_HeaderType Workday_Common_Header, Request_Bonus_Payment_RequestType Request_Bonus_Payment_Request)
		{
			return ((CompensationPort)this).Request_Bonus_Payment(new Request_Bonus_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Bonus_Payment_Request = Request_Bonus_Payment_Request
			}).Request_Bonus_Payment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Request_Bonus_PaymentOutput> CompensationPort.Request_Bonus_PaymentAsync(Request_Bonus_PaymentInput request)
		{
			return base.Channel.Request_Bonus_PaymentAsync(request);
		}

		public Task<Request_Bonus_PaymentOutput> Request_Bonus_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Request_Bonus_Payment_RequestType Request_Bonus_Payment_Request)
		{
			return ((CompensationPort)this).Request_Bonus_PaymentAsync(new Request_Bonus_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Bonus_Payment_Request = Request_Bonus_Payment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Request_Employee_Merit_AdjustmentOutput CompensationPort.Request_Employee_Merit_Adjustment(Request_Employee_Merit_AdjustmentInput request)
		{
			return base.Channel.Request_Employee_Merit_Adjustment(request);
		}

		public Request_Employee_Merit_Adjustment_ResponseType Request_Employee_Merit_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Request_Employee_Merit_Adjustment_RequestType Request_Employee_Merit_Adjustment_Request)
		{
			return ((CompensationPort)this).Request_Employee_Merit_Adjustment(new Request_Employee_Merit_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Employee_Merit_Adjustment_Request = Request_Employee_Merit_Adjustment_Request
			}).Request_Employee_Merit_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Request_Employee_Merit_AdjustmentOutput> CompensationPort.Request_Employee_Merit_AdjustmentAsync(Request_Employee_Merit_AdjustmentInput request)
		{
			return base.Channel.Request_Employee_Merit_AdjustmentAsync(request);
		}

		public Task<Request_Employee_Merit_AdjustmentOutput> Request_Employee_Merit_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Request_Employee_Merit_Adjustment_RequestType Request_Employee_Merit_Adjustment_Request)
		{
			return ((CompensationPort)this).Request_Employee_Merit_AdjustmentAsync(new Request_Employee_Merit_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Employee_Merit_Adjustment_Request = Request_Employee_Merit_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Request_OneTime_PaymentOutput CompensationPort.Request_OneTime_Payment(Request_OneTime_PaymentInput request)
		{
			return base.Channel.Request_OneTime_Payment(request);
		}

		public Request_OneTime_Payment_ResponseType Request_OneTime_Payment(Workday_Common_HeaderType Workday_Common_Header, Request_OneTime_Payment_RequestType Request_OneTime_Payment_Request)
		{
			return ((CompensationPort)this).Request_OneTime_Payment(new Request_OneTime_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_OneTime_Payment_Request = Request_OneTime_Payment_Request
			}).Request_OneTime_Payment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Request_OneTime_PaymentOutput> CompensationPort.Request_OneTime_PaymentAsync(Request_OneTime_PaymentInput request)
		{
			return base.Channel.Request_OneTime_PaymentAsync(request);
		}

		public Task<Request_OneTime_PaymentOutput> Request_OneTime_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Request_OneTime_Payment_RequestType Request_OneTime_Payment_Request)
		{
			return ((CompensationPort)this).Request_OneTime_PaymentAsync(new Request_OneTime_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_OneTime_Payment_Request = Request_OneTime_Payment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Request_Compensation_ChangeOutput CompensationPort.Request_Compensation_Change(Request_Compensation_ChangeInput request)
		{
			return base.Channel.Request_Compensation_Change(request);
		}

		public Request_Compensation_Change_ResponseType Request_Compensation_Change(Workday_Common_HeaderType Workday_Common_Header, Request_Compensation_Change_RequestType Request_Compensation_Change_Request)
		{
			return ((CompensationPort)this).Request_Compensation_Change(new Request_Compensation_ChangeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Compensation_Change_Request = Request_Compensation_Change_Request
			}).Request_Compensation_Change_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Request_Compensation_ChangeOutput> CompensationPort.Request_Compensation_ChangeAsync(Request_Compensation_ChangeInput request)
		{
			return base.Channel.Request_Compensation_ChangeAsync(request);
		}

		public Task<Request_Compensation_ChangeOutput> Request_Compensation_ChangeAsync(Workday_Common_HeaderType Workday_Common_Header, Request_Compensation_Change_RequestType Request_Compensation_Change_Request)
		{
			return ((CompensationPort)this).Request_Compensation_ChangeAsync(new Request_Compensation_ChangeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Compensation_Change_Request = Request_Compensation_Change_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Eligible_EarningsOutput CompensationPort.Put_Eligible_Earnings(Put_Eligible_EarningsInput request)
		{
			return base.Channel.Put_Eligible_Earnings(request);
		}

		public Put_Eligible_Earnings_ResponseType Put_Eligible_Earnings(Workday_Common_HeaderType Workday_Common_Header, Put_Eligible_Earnings_RequestType Put_Eligible_Earnings_Request)
		{
			return ((CompensationPort)this).Put_Eligible_Earnings(new Put_Eligible_EarningsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Eligible_Earnings_Request = Put_Eligible_Earnings_Request
			}).Put_Eligible_Earnings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Eligible_EarningsOutput> CompensationPort.Put_Eligible_EarningsAsync(Put_Eligible_EarningsInput request)
		{
			return base.Channel.Put_Eligible_EarningsAsync(request);
		}

		public Task<Put_Eligible_EarningsOutput> Put_Eligible_EarningsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Eligible_Earnings_RequestType Put_Eligible_Earnings_Request)
		{
			return ((CompensationPort)this).Put_Eligible_EarningsAsync(new Put_Eligible_EarningsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Eligible_Earnings_Request = Put_Eligible_Earnings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Eligible_EarningsOutput CompensationPort.Get_Eligible_Earnings(Get_Eligible_EarningsInput request)
		{
			return base.Channel.Get_Eligible_Earnings(request);
		}

		public Get_Eligible_Earnings_ResponseType Get_Eligible_Earnings(Workday_Common_HeaderType Workday_Common_Header, Get_Eligible_Earnings_RequestType Get_Eligible_Earnings_Request)
		{
			return ((CompensationPort)this).Get_Eligible_Earnings(new Get_Eligible_EarningsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Eligible_Earnings_Request = Get_Eligible_Earnings_Request
			}).Get_Eligible_Earnings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Eligible_EarningsOutput> CompensationPort.Get_Eligible_EarningsAsync(Get_Eligible_EarningsInput request)
		{
			return base.Channel.Get_Eligible_EarningsAsync(request);
		}

		public Task<Get_Eligible_EarningsOutput> Get_Eligible_EarningsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Eligible_Earnings_RequestType Get_Eligible_Earnings_Request)
		{
			return ((CompensationPort)this).Get_Eligible_EarningsAsync(new Get_Eligible_EarningsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Eligible_Earnings_Request = Get_Eligible_Earnings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Compensation_MatricesOutput CompensationPort.Get_Compensation_Matrices(Get_Compensation_MatricesInput request)
		{
			return base.Channel.Get_Compensation_Matrices(request);
		}

		public Get_Compensation_Matrices_ResponseType Get_Compensation_Matrices(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Matrices_RequestType Get_Compensation_Matrices_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Matrices(new Get_Compensation_MatricesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Matrices_Request = Get_Compensation_Matrices_Request
			}).Get_Compensation_Matrices_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Compensation_MatricesOutput> CompensationPort.Get_Compensation_MatricesAsync(Get_Compensation_MatricesInput request)
		{
			return base.Channel.Get_Compensation_MatricesAsync(request);
		}

		public Task<Get_Compensation_MatricesOutput> Get_Compensation_MatricesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Matrices_RequestType Get_Compensation_Matrices_Request)
		{
			return ((CompensationPort)this).Get_Compensation_MatricesAsync(new Get_Compensation_MatricesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Matrices_Request = Get_Compensation_Matrices_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Compensation_MatrixOutput CompensationPort.Put_Compensation_Matrix(Put_Compensation_MatrixInput request)
		{
			return base.Channel.Put_Compensation_Matrix(request);
		}

		public Put_Compensation_Matrix_ResponseType Put_Compensation_Matrix(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Matrix_RequestType Put_Compensation_Matrix_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Matrix(new Put_Compensation_MatrixInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Matrix_Request = Put_Compensation_Matrix_Request
			}).Put_Compensation_Matrix_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Compensation_MatrixOutput> CompensationPort.Put_Compensation_MatrixAsync(Put_Compensation_MatrixInput request)
		{
			return base.Channel.Put_Compensation_MatrixAsync(request);
		}

		public Task<Put_Compensation_MatrixOutput> Put_Compensation_MatrixAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Matrix_RequestType Put_Compensation_Matrix_Request)
		{
			return ((CompensationPort)this).Put_Compensation_MatrixAsync(new Put_Compensation_MatrixInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Matrix_Request = Put_Compensation_Matrix_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Compensation_GradesOutput CompensationPort.Get_Compensation_Grades(Get_Compensation_GradesInput request)
		{
			return base.Channel.Get_Compensation_Grades(request);
		}

		public Get_Compensation_Grades_ResponseType Get_Compensation_Grades(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Grades_RequestType Get_Compensation_Grades_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Grades(new Get_Compensation_GradesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Grades_Request = Get_Compensation_Grades_Request
			}).Get_Compensation_Grades_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Compensation_GradesOutput> CompensationPort.Get_Compensation_GradesAsync(Get_Compensation_GradesInput request)
		{
			return base.Channel.Get_Compensation_GradesAsync(request);
		}

		public Task<Get_Compensation_GradesOutput> Get_Compensation_GradesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Grades_RequestType Get_Compensation_Grades_Request)
		{
			return ((CompensationPort)this).Get_Compensation_GradesAsync(new Get_Compensation_GradesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Grades_Request = Get_Compensation_Grades_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Compensation_GradeOutput CompensationPort.Put_Compensation_Grade(Put_Compensation_GradeInput request)
		{
			return base.Channel.Put_Compensation_Grade(request);
		}

		public Put_Compensation_Grade_ResponseType Put_Compensation_Grade(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Grade_RequestType Put_Compensation_Grade_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Grade(new Put_Compensation_GradeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Grade_Request = Put_Compensation_Grade_Request
			}).Put_Compensation_Grade_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Compensation_GradeOutput> CompensationPort.Put_Compensation_GradeAsync(Put_Compensation_GradeInput request)
		{
			return base.Channel.Put_Compensation_GradeAsync(request);
		}

		public Task<Put_Compensation_GradeOutput> Put_Compensation_GradeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Grade_RequestType Put_Compensation_Grade_Request)
		{
			return ((CompensationPort)this).Put_Compensation_GradeAsync(new Put_Compensation_GradeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Grade_Request = Put_Compensation_Grade_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Compensation_PlansOutput CompensationPort.Get_Compensation_Plans(Get_Compensation_PlansInput request)
		{
			return base.Channel.Get_Compensation_Plans(request);
		}

		public Get_Compensation_Plans_ResponseType Get_Compensation_Plans(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Plans_RequestType Get_Compensation_Plans_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Plans(new Get_Compensation_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Plans_Request = Get_Compensation_Plans_Request
			}).Get_Compensation_Plans_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Compensation_PlansOutput> CompensationPort.Get_Compensation_PlansAsync(Get_Compensation_PlansInput request)
		{
			return base.Channel.Get_Compensation_PlansAsync(request);
		}

		public Task<Get_Compensation_PlansOutput> Get_Compensation_PlansAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Plans_RequestType Get_Compensation_Plans_Request)
		{
			return ((CompensationPort)this).Get_Compensation_PlansAsync(new Get_Compensation_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Plans_Request = Get_Compensation_Plans_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Compensation_PlansOutput CompensationPort.Put_Compensation_Plans(Put_Compensation_PlansInput request)
		{
			return base.Channel.Put_Compensation_Plans(request);
		}

		public Put_Compensation_Plan_ResponseType Put_Compensation_Plans(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Plan_RequestType Put_Compensation_Plan_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Plans(new Put_Compensation_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Plan_Request = Put_Compensation_Plan_Request
			}).Put_Compensation_Plan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Compensation_PlansOutput> CompensationPort.Put_Compensation_PlansAsync(Put_Compensation_PlansInput request)
		{
			return base.Channel.Put_Compensation_PlansAsync(request);
		}

		public Task<Put_Compensation_PlansOutput> Put_Compensation_PlansAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Plan_RequestType Put_Compensation_Plan_Request)
		{
			return ((CompensationPort)this).Put_Compensation_PlansAsync(new Put_Compensation_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Plan_Request = Put_Compensation_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Future_Payment_Plan_AssignmentsOutput CompensationPort.Get_Future_Payment_Plan_Assignments(Get_Future_Payment_Plan_AssignmentsInput request)
		{
			return base.Channel.Get_Future_Payment_Plan_Assignments(request);
		}

		public Get_Future_Payment_Plan_Assignments_ResponseType Get_Future_Payment_Plan_Assignments(Workday_Common_HeaderType Workday_Common_Header, Get_Future_Payment_Plan_Assignments_RequestType Get_Future_Payment_Plan_Assignments_Request)
		{
			return ((CompensationPort)this).Get_Future_Payment_Plan_Assignments(new Get_Future_Payment_Plan_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Future_Payment_Plan_Assignments_Request = Get_Future_Payment_Plan_Assignments_Request
			}).Get_Future_Payment_Plan_Assignments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Future_Payment_Plan_AssignmentsOutput> CompensationPort.Get_Future_Payment_Plan_AssignmentsAsync(Get_Future_Payment_Plan_AssignmentsInput request)
		{
			return base.Channel.Get_Future_Payment_Plan_AssignmentsAsync(request);
		}

		public Task<Get_Future_Payment_Plan_AssignmentsOutput> Get_Future_Payment_Plan_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Future_Payment_Plan_Assignments_RequestType Get_Future_Payment_Plan_Assignments_Request)
		{
			return ((CompensationPort)this).Get_Future_Payment_Plan_AssignmentsAsync(new Get_Future_Payment_Plan_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Future_Payment_Plan_Assignments_Request = Get_Future_Payment_Plan_Assignments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Future_Payment_Plan_AssignmentOutput CompensationPort.Put_Future_Payment_Plan_Assignment(Put_Future_Payment_Plan_AssignmentInput request)
		{
			return base.Channel.Put_Future_Payment_Plan_Assignment(request);
		}

		public Put_Future_Payment_Plan_Assignment_ResponseType Put_Future_Payment_Plan_Assignment(Workday_Common_HeaderType Workday_Common_Header, Put_Future_Payment_Plan_Assignment_RequestType Put_Future_Payment_Plan_Assignment_Request)
		{
			return ((CompensationPort)this).Put_Future_Payment_Plan_Assignment(new Put_Future_Payment_Plan_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Future_Payment_Plan_Assignment_Request = Put_Future_Payment_Plan_Assignment_Request
			}).Put_Future_Payment_Plan_Assignment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Future_Payment_Plan_AssignmentOutput> CompensationPort.Put_Future_Payment_Plan_AssignmentAsync(Put_Future_Payment_Plan_AssignmentInput request)
		{
			return base.Channel.Put_Future_Payment_Plan_AssignmentAsync(request);
		}

		public Task<Put_Future_Payment_Plan_AssignmentOutput> Put_Future_Payment_Plan_AssignmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Future_Payment_Plan_Assignment_RequestType Put_Future_Payment_Plan_Assignment_Request)
		{
			return ((CompensationPort)this).Put_Future_Payment_Plan_AssignmentAsync(new Put_Future_Payment_Plan_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Future_Payment_Plan_Assignment_Request = Put_Future_Payment_Plan_Assignment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Compensation_ScorecardsOutput CompensationPort.Get_Compensation_Scorecards(Get_Compensation_ScorecardsInput request)
		{
			return base.Channel.Get_Compensation_Scorecards(request);
		}

		public Get_Compensation_Scorecards_ResponseType Get_Compensation_Scorecards(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Scorecards_RequestType Get_Compensation_Scorecards_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Scorecards(new Get_Compensation_ScorecardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Scorecards_Request = Get_Compensation_Scorecards_Request
			}).Get_Compensation_Scorecards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Compensation_ScorecardsOutput> CompensationPort.Get_Compensation_ScorecardsAsync(Get_Compensation_ScorecardsInput request)
		{
			return base.Channel.Get_Compensation_ScorecardsAsync(request);
		}

		public Task<Get_Compensation_ScorecardsOutput> Get_Compensation_ScorecardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Scorecards_RequestType Get_Compensation_Scorecards_Request)
		{
			return ((CompensationPort)this).Get_Compensation_ScorecardsAsync(new Get_Compensation_ScorecardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Scorecards_Request = Get_Compensation_Scorecards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Compensation_ScorecardOutput CompensationPort.Put_Compensation_Scorecard(Put_Compensation_ScorecardInput request)
		{
			return base.Channel.Put_Compensation_Scorecard(request);
		}

		public Put_Compensation_Scorecard_ResponseType Put_Compensation_Scorecard(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Scorecard_RequestType Put_Compensation_Scorecard_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Scorecard(new Put_Compensation_ScorecardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Scorecard_Request = Put_Compensation_Scorecard_Request
			}).Put_Compensation_Scorecard_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Compensation_ScorecardOutput> CompensationPort.Put_Compensation_ScorecardAsync(Put_Compensation_ScorecardInput request)
		{
			return base.Channel.Put_Compensation_ScorecardAsync(request);
		}

		public Task<Put_Compensation_ScorecardOutput> Put_Compensation_ScorecardAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Scorecard_RequestType Put_Compensation_Scorecard_Request)
		{
			return ((CompensationPort)this).Put_Compensation_ScorecardAsync(new Put_Compensation_ScorecardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Scorecard_Request = Put_Compensation_Scorecard_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Benchmark_JobOutput CompensationPort.Put_Benchmark_Job(Put_Benchmark_JobInput request)
		{
			return base.Channel.Put_Benchmark_Job(request);
		}

		public Put_Benchmark_Job_ResponseType Put_Benchmark_Job(Workday_Common_HeaderType Workday_Common_Header, Put_Benchmark_Job_RequestType Put_Benchmark_Job_Request)
		{
			return ((CompensationPort)this).Put_Benchmark_Job(new Put_Benchmark_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benchmark_Job_Request = Put_Benchmark_Job_Request
			}).Put_Benchmark_Job_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Benchmark_JobOutput> CompensationPort.Put_Benchmark_JobAsync(Put_Benchmark_JobInput request)
		{
			return base.Channel.Put_Benchmark_JobAsync(request);
		}

		public Task<Put_Benchmark_JobOutput> Put_Benchmark_JobAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Benchmark_Job_RequestType Put_Benchmark_Job_Request)
		{
			return ((CompensationPort)this).Put_Benchmark_JobAsync(new Put_Benchmark_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benchmark_Job_Request = Put_Benchmark_Job_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Benchmark_JobsOutput CompensationPort.Get_Benchmark_Jobs(Get_Benchmark_JobsInput request)
		{
			return base.Channel.Get_Benchmark_Jobs(request);
		}

		public Get_Benchmark_Jobs_ResponseType Get_Benchmark_Jobs(Workday_Common_HeaderType Workday_Common_Header, Get_Benchmark_Jobs_RequestType Get_Benchmark_Jobs_Request)
		{
			return ((CompensationPort)this).Get_Benchmark_Jobs(new Get_Benchmark_JobsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benchmark_Jobs_Request = Get_Benchmark_Jobs_Request
			}).Get_Benchmark_Jobs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Benchmark_JobsOutput> CompensationPort.Get_Benchmark_JobsAsync(Get_Benchmark_JobsInput request)
		{
			return base.Channel.Get_Benchmark_JobsAsync(request);
		}

		public Task<Get_Benchmark_JobsOutput> Get_Benchmark_JobsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Benchmark_Jobs_RequestType Get_Benchmark_Jobs_Request)
		{
			return ((CompensationPort)this).Get_Benchmark_JobsAsync(new Get_Benchmark_JobsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benchmark_Jobs_Request = Get_Benchmark_Jobs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Stock_GrantOutput CompensationPort.Update_Stock_Grant(Update_Stock_GrantInput request)
		{
			return base.Channel.Update_Stock_Grant(request);
		}

		public Update_Stock_Grant_ResponseType Update_Stock_Grant(Workday_Common_HeaderType Workday_Common_Header, Update_Stock_Grant_RequestType Update_Stock_Grant_Request)
		{
			return ((CompensationPort)this).Update_Stock_Grant(new Update_Stock_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Stock_Grant_Request = Update_Stock_Grant_Request
			}).Update_Stock_Grant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Stock_GrantOutput> CompensationPort.Update_Stock_GrantAsync(Update_Stock_GrantInput request)
		{
			return base.Channel.Update_Stock_GrantAsync(request);
		}

		public Task<Update_Stock_GrantOutput> Update_Stock_GrantAsync(Workday_Common_HeaderType Workday_Common_Header, Update_Stock_Grant_RequestType Update_Stock_Grant_Request)
		{
			return ((CompensationPort)this).Update_Stock_GrantAsync(new Update_Stock_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Stock_Grant_Request = Update_Stock_Grant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_Stock_GrantOutput CompensationPort.Add_Stock_Grant(Add_Stock_GrantInput request)
		{
			return base.Channel.Add_Stock_Grant(request);
		}

		public Add_Stock_Grant_ResponseType Add_Stock_Grant(Workday_Common_HeaderType Workday_Common_Header, Add_Stock_Grant_RequestType Add_Stock_Grant_Request)
		{
			return ((CompensationPort)this).Add_Stock_Grant(new Add_Stock_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Stock_Grant_Request = Add_Stock_Grant_Request
			}).Add_Stock_Grant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_Stock_GrantOutput> CompensationPort.Add_Stock_GrantAsync(Add_Stock_GrantInput request)
		{
			return base.Channel.Add_Stock_GrantAsync(request);
		}

		public Task<Add_Stock_GrantOutput> Add_Stock_GrantAsync(Workday_Common_HeaderType Workday_Common_Header, Add_Stock_Grant_RequestType Add_Stock_Grant_Request)
		{
			return ((CompensationPort)this).Add_Stock_GrantAsync(new Add_Stock_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Stock_Grant_Request = Add_Stock_Grant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Compensation_Eligibility_RuleOutput CompensationPort.Put_Compensation_Eligibility_Rule(Put_Compensation_Eligibility_RuleInput request)
		{
			return base.Channel.Put_Compensation_Eligibility_Rule(request);
		}

		public Put_Compensation_Eligibility_Rule_ResponseType Put_Compensation_Eligibility_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Eligibility_Rule_RequestType Put_Compensation_Eligibility_Rule_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Eligibility_Rule(new Put_Compensation_Eligibility_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Eligibility_Rule_Request = Put_Compensation_Eligibility_Rule_Request
			}).Put_Compensation_Eligibility_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Compensation_Eligibility_RuleOutput> CompensationPort.Put_Compensation_Eligibility_RuleAsync(Put_Compensation_Eligibility_RuleInput request)
		{
			return base.Channel.Put_Compensation_Eligibility_RuleAsync(request);
		}

		public Task<Put_Compensation_Eligibility_RuleOutput> Put_Compensation_Eligibility_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Eligibility_Rule_RequestType Put_Compensation_Eligibility_Rule_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Eligibility_RuleAsync(new Put_Compensation_Eligibility_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Eligibility_Rule_Request = Put_Compensation_Eligibility_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Compensation_Eligibility_RulesOutput CompensationPort.Get_Compensation_Eligibility_Rules(Get_Compensation_Eligibility_RulesInput request)
		{
			return base.Channel.Get_Compensation_Eligibility_Rules(request);
		}

		public Get_Compensation_Eligibility_Rules_ResponseType Get_Compensation_Eligibility_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Eligibility_Rules_RequestType Get_Compensation_Eligibility_Rules_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Eligibility_Rules(new Get_Compensation_Eligibility_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Eligibility_Rules_Request = Get_Compensation_Eligibility_Rules_Request
			}).Get_Compensation_Eligibility_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Compensation_Eligibility_RulesOutput> CompensationPort.Get_Compensation_Eligibility_RulesAsync(Get_Compensation_Eligibility_RulesInput request)
		{
			return base.Channel.Get_Compensation_Eligibility_RulesAsync(request);
		}

		public Task<Get_Compensation_Eligibility_RulesOutput> Get_Compensation_Eligibility_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Eligibility_Rules_RequestType Get_Compensation_Eligibility_Rules_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Eligibility_RulesAsync(new Get_Compensation_Eligibility_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Eligibility_Rules_Request = Get_Compensation_Eligibility_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Compensation_Eligibility_RulesOutput CompensationPort.Get_Compensation_Eligibility_Rules_without_Dependencies(Get_Compensation_Eligibility_Rules_without_DependenciesInput request)
		{
			return base.Channel.Get_Compensation_Eligibility_Rules_without_Dependencies(request);
		}

		public Get_Compensation_Eligibility_Rules_ResponseType Get_Compensation_Eligibility_Rules_without_Dependencies(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Eligibility_Rules_without_Dependencies_RequestType Get_Compensation_Eligibility_Rules_without_Dependencies_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Eligibility_Rules_without_Dependencies(new Get_Compensation_Eligibility_Rules_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Eligibility_Rules_without_Dependencies_Request = Get_Compensation_Eligibility_Rules_without_Dependencies_Request
			}).Get_Compensation_Eligibility_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Compensation_Eligibility_RulesOutput> CompensationPort.Get_Compensation_Eligibility_Rules_without_DependenciesAsync(Get_Compensation_Eligibility_Rules_without_DependenciesInput request)
		{
			return base.Channel.Get_Compensation_Eligibility_Rules_without_DependenciesAsync(request);
		}

		public Task<Get_Compensation_Eligibility_RulesOutput> Get_Compensation_Eligibility_Rules_without_DependenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Eligibility_Rules_without_Dependencies_RequestType Get_Compensation_Eligibility_Rules_without_Dependencies_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Eligibility_Rules_without_DependenciesAsync(new Get_Compensation_Eligibility_Rules_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Eligibility_Rules_without_Dependencies_Request = Get_Compensation_Eligibility_Rules_without_Dependencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Compensation_Scorecard_ResultOutput CompensationPort.Put_Compensation_Scorecard_Result(Put_Compensation_Scorecard_ResultInput request)
		{
			return base.Channel.Put_Compensation_Scorecard_Result(request);
		}

		public Put_Compensation_Scorecard_Result_ResponseType Put_Compensation_Scorecard_Result(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Scorecard_Result_RequestType Put_Compensation_Scorecard_Result_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Scorecard_Result(new Put_Compensation_Scorecard_ResultInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Scorecard_Result_Request = Put_Compensation_Scorecard_Result_Request
			}).Put_Compensation_Scorecard_Result_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Compensation_Scorecard_ResultOutput> CompensationPort.Put_Compensation_Scorecard_ResultAsync(Put_Compensation_Scorecard_ResultInput request)
		{
			return base.Channel.Put_Compensation_Scorecard_ResultAsync(request);
		}

		public Task<Put_Compensation_Scorecard_ResultOutput> Put_Compensation_Scorecard_ResultAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Compensation_Scorecard_Result_RequestType Put_Compensation_Scorecard_Result_Request)
		{
			return ((CompensationPort)this).Put_Compensation_Scorecard_ResultAsync(new Put_Compensation_Scorecard_ResultInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Compensation_Scorecard_Result_Request = Put_Compensation_Scorecard_Result_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Compensation_Scorecard_ResultsOutput CompensationPort.Get_Compensation_Scorecard_Results(Get_Compensation_Scorecard_ResultsInput request)
		{
			return base.Channel.Get_Compensation_Scorecard_Results(request);
		}

		public Get_Compensation_Scorecard_Results_ResponseType Get_Compensation_Scorecard_Results(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Scorecard_Results_RequestType Get_Compensation_Scorecard_Results_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Scorecard_Results(new Get_Compensation_Scorecard_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Scorecard_Results_Request = Get_Compensation_Scorecard_Results_Request
			}).Get_Compensation_Scorecard_Results_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Compensation_Scorecard_ResultsOutput> CompensationPort.Get_Compensation_Scorecard_ResultsAsync(Get_Compensation_Scorecard_ResultsInput request)
		{
			return base.Channel.Get_Compensation_Scorecard_ResultsAsync(request);
		}

		public Task<Get_Compensation_Scorecard_ResultsOutput> Get_Compensation_Scorecard_ResultsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Scorecard_Results_RequestType Get_Compensation_Scorecard_Results_Request)
		{
			return ((CompensationPort)this).Get_Compensation_Scorecard_ResultsAsync(new Get_Compensation_Scorecard_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Compensation_Scorecard_Results_Request = Get_Compensation_Scorecard_Results_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Launch_Employee_Severance_WorksheetOutput CompensationPort.Launch_Employee_Severance_Worksheet(Launch_Employee_Severance_WorksheetInput request)
		{
			return base.Channel.Launch_Employee_Severance_Worksheet(request);
		}

		public Launch_Employee_Severance_Worksheet_ResponseType Launch_Employee_Severance_Worksheet(Workday_Common_HeaderType Workday_Common_Header, Launch_Employee_Severance_Worksheet_RequestType Launch_Employee_Severance_Worksheet_Request)
		{
			return ((CompensationPort)this).Launch_Employee_Severance_Worksheet(new Launch_Employee_Severance_WorksheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_Employee_Severance_Worksheet_Request = Launch_Employee_Severance_Worksheet_Request
			}).Launch_Employee_Severance_Worksheet_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Launch_Employee_Severance_WorksheetOutput> CompensationPort.Launch_Employee_Severance_WorksheetAsync(Launch_Employee_Severance_WorksheetInput request)
		{
			return base.Channel.Launch_Employee_Severance_WorksheetAsync(request);
		}

		public Task<Launch_Employee_Severance_WorksheetOutput> Launch_Employee_Severance_WorksheetAsync(Workday_Common_HeaderType Workday_Common_Header, Launch_Employee_Severance_Worksheet_RequestType Launch_Employee_Severance_Worksheet_Request)
		{
			return ((CompensationPort)this).Launch_Employee_Severance_WorksheetAsync(new Launch_Employee_Severance_WorksheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_Employee_Severance_Worksheet_Request = Launch_Employee_Severance_Worksheet_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Period_Activity_TasksOutput CompensationPort.Get_Period_Activity_Tasks(Get_Period_Activity_TasksInput request)
		{
			return base.Channel.Get_Period_Activity_Tasks(request);
		}

		public Get_Period_Activity_Tasks_ResponseType Get_Period_Activity_Tasks(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Activity_Tasks_RequestType Get_Period_Activity_Tasks_Request)
		{
			return ((CompensationPort)this).Get_Period_Activity_Tasks(new Get_Period_Activity_TasksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Activity_Tasks_Request = Get_Period_Activity_Tasks_Request
			}).Get_Period_Activity_Tasks_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Period_Activity_TasksOutput> CompensationPort.Get_Period_Activity_TasksAsync(Get_Period_Activity_TasksInput request)
		{
			return base.Channel.Get_Period_Activity_TasksAsync(request);
		}

		public Task<Get_Period_Activity_TasksOutput> Get_Period_Activity_TasksAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Activity_Tasks_RequestType Get_Period_Activity_Tasks_Request)
		{
			return ((CompensationPort)this).Get_Period_Activity_TasksAsync(new Get_Period_Activity_TasksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Activity_Tasks_Request = Get_Period_Activity_Tasks_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Period_Activity_TaskOutput CompensationPort.Put_Period_Activity_Task(Put_Period_Activity_TaskInput request)
		{
			return base.Channel.Put_Period_Activity_Task(request);
		}

		public Put_Period_Activity_Task_ResponseType Put_Period_Activity_Task(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Activity_Task_RequestType Put_Period_Activity_Task_Request)
		{
			return ((CompensationPort)this).Put_Period_Activity_Task(new Put_Period_Activity_TaskInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Activity_Task_Request = Put_Period_Activity_Task_Request
			}).Put_Period_Activity_Task_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Period_Activity_TaskOutput> CompensationPort.Put_Period_Activity_TaskAsync(Put_Period_Activity_TaskInput request)
		{
			return base.Channel.Put_Period_Activity_TaskAsync(request);
		}

		public Task<Put_Period_Activity_TaskOutput> Put_Period_Activity_TaskAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Activity_Task_RequestType Put_Period_Activity_Task_Request)
		{
			return ((CompensationPort)this).Put_Period_Activity_TaskAsync(new Put_Period_Activity_TaskInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Activity_Task_Request = Put_Period_Activity_Task_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_Eligible_Period_Activities_for_EmployeeOutput CompensationPort.Assign_Eligible_Period_Activities_for_Employee(Assign_Eligible_Period_Activities_for_EmployeeInput request)
		{
			return base.Channel.Assign_Eligible_Period_Activities_for_Employee(request);
		}

		public Assign_Eligible_Period_Activities_for_Employee_ResponseType Assign_Eligible_Period_Activities_for_Employee(Workday_Common_HeaderType Workday_Common_Header, Assign_Eligible_Period_Activities_for_Employee_RequestType Assign_Eligible_Period_Activities_for_Employee_Request)
		{
			return ((CompensationPort)this).Assign_Eligible_Period_Activities_for_Employee(new Assign_Eligible_Period_Activities_for_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Eligible_Period_Activities_for_Employee_Request = Assign_Eligible_Period_Activities_for_Employee_Request
			}).Assign_Eligible_Period_Activities_for_Employee_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_Eligible_Period_Activities_for_EmployeeOutput> CompensationPort.Assign_Eligible_Period_Activities_for_EmployeeAsync(Assign_Eligible_Period_Activities_for_EmployeeInput request)
		{
			return base.Channel.Assign_Eligible_Period_Activities_for_EmployeeAsync(request);
		}

		public Task<Assign_Eligible_Period_Activities_for_EmployeeOutput> Assign_Eligible_Period_Activities_for_EmployeeAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Eligible_Period_Activities_for_Employee_RequestType Assign_Eligible_Period_Activities_for_Employee_Request)
		{
			return ((CompensationPort)this).Assign_Eligible_Period_Activities_for_EmployeeAsync(new Assign_Eligible_Period_Activities_for_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Eligible_Period_Activities_for_Employee_Request = Assign_Eligible_Period_Activities_for_Employee_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Period_Activity_Rate_MatrixOutput CompensationPort.Put_Period_Activity_Rate_Matrix(Put_Period_Activity_Rate_MatrixInput request)
		{
			return base.Channel.Put_Period_Activity_Rate_Matrix(request);
		}

		public Put_Period_Activity_Rate_Matrix_ResponseType Put_Period_Activity_Rate_Matrix(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Activity_Rate_Matrix_RequestType Put_Period_Activity_Rate_Matrix_Request)
		{
			return ((CompensationPort)this).Put_Period_Activity_Rate_Matrix(new Put_Period_Activity_Rate_MatrixInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Activity_Rate_Matrix_Request = Put_Period_Activity_Rate_Matrix_Request
			}).Put_Period_Activity_Rate_Matrix_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Period_Activity_Rate_MatrixOutput> CompensationPort.Put_Period_Activity_Rate_MatrixAsync(Put_Period_Activity_Rate_MatrixInput request)
		{
			return base.Channel.Put_Period_Activity_Rate_MatrixAsync(request);
		}

		public Task<Put_Period_Activity_Rate_MatrixOutput> Put_Period_Activity_Rate_MatrixAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Activity_Rate_Matrix_RequestType Put_Period_Activity_Rate_Matrix_Request)
		{
			return ((CompensationPort)this).Put_Period_Activity_Rate_MatrixAsync(new Put_Period_Activity_Rate_MatrixInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Activity_Rate_Matrix_Request = Put_Period_Activity_Rate_Matrix_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Period_Activity_Rate_MatricesOutput CompensationPort.Get_Period_Activity_Rate_Matrices(Get_Period_Activity_Rate_MatricesInput request)
		{
			return base.Channel.Get_Period_Activity_Rate_Matrices(request);
		}

		public Get_Period_Activity_Rate_Matrices_ResponseType Get_Period_Activity_Rate_Matrices(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Activity_Rate_Matrices_RequestType Get_Period_Activity_Rate_Matrices_Request)
		{
			return ((CompensationPort)this).Get_Period_Activity_Rate_Matrices(new Get_Period_Activity_Rate_MatricesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Activity_Rate_Matrices_Request = Get_Period_Activity_Rate_Matrices_Request
			}).Get_Period_Activity_Rate_Matrices_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Period_Activity_Rate_MatricesOutput> CompensationPort.Get_Period_Activity_Rate_MatricesAsync(Get_Period_Activity_Rate_MatricesInput request)
		{
			return base.Channel.Get_Period_Activity_Rate_MatricesAsync(request);
		}

		public Task<Get_Period_Activity_Rate_MatricesOutput> Get_Period_Activity_Rate_MatricesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Activity_Rate_Matrices_RequestType Get_Period_Activity_Rate_Matrices_Request)
		{
			return ((CompensationPort)this).Get_Period_Activity_Rate_MatricesAsync(new Get_Period_Activity_Rate_MatricesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Activity_Rate_Matrices_Request = Get_Period_Activity_Rate_Matrices_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Period_Activity_Pay_AssignmentsOutput CompensationPort.Manage_Period_Activity_Pay_Assignments(Manage_Period_Activity_Pay_AssignmentsInput request)
		{
			return base.Channel.Manage_Period_Activity_Pay_Assignments(request);
		}

		public Manage_Period_Activity_Pay_Assignments_ResponseType Manage_Period_Activity_Pay_Assignments(Workday_Common_HeaderType Workday_Common_Header, Manage_Period_Activity_Pay_Assignments_RequestType Manage_Period_Activity_Pay_Assignments_Request)
		{
			return ((CompensationPort)this).Manage_Period_Activity_Pay_Assignments(new Manage_Period_Activity_Pay_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Period_Activity_Pay_Assignments_Request = Manage_Period_Activity_Pay_Assignments_Request
			}).Manage_Period_Activity_Pay_Assignments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Period_Activity_Pay_AssignmentsOutput> CompensationPort.Manage_Period_Activity_Pay_AssignmentsAsync(Manage_Period_Activity_Pay_AssignmentsInput request)
		{
			return base.Channel.Manage_Period_Activity_Pay_AssignmentsAsync(request);
		}

		public Task<Manage_Period_Activity_Pay_AssignmentsOutput> Manage_Period_Activity_Pay_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Period_Activity_Pay_Assignments_RequestType Manage_Period_Activity_Pay_Assignments_Request)
		{
			return ((CompensationPort)this).Manage_Period_Activity_Pay_AssignmentsAsync(new Manage_Period_Activity_Pay_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Period_Activity_Pay_Assignments_Request = Manage_Period_Activity_Pay_Assignments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Stock_Participation_Rate_TableOutput CompensationPort.Put_Stock_Participation_Rate_Table(Put_Stock_Participation_Rate_TableInput request)
		{
			return base.Channel.Put_Stock_Participation_Rate_Table(request);
		}

		public Put_Stock_Participation_Rate_Table_ResponseType Put_Stock_Participation_Rate_Table(Workday_Common_HeaderType Workday_Common_Header, Put_Stock_Participation_Rate_Table_RequestType Put_Stock_Participation_Rate_Table_Request)
		{
			return ((CompensationPort)this).Put_Stock_Participation_Rate_Table(new Put_Stock_Participation_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Stock_Participation_Rate_Table_Request = Put_Stock_Participation_Rate_Table_Request
			}).Put_Stock_Participation_Rate_Table_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Stock_Participation_Rate_TableOutput> CompensationPort.Put_Stock_Participation_Rate_TableAsync(Put_Stock_Participation_Rate_TableInput request)
		{
			return base.Channel.Put_Stock_Participation_Rate_TableAsync(request);
		}

		public Task<Put_Stock_Participation_Rate_TableOutput> Put_Stock_Participation_Rate_TableAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Stock_Participation_Rate_Table_RequestType Put_Stock_Participation_Rate_Table_Request)
		{
			return ((CompensationPort)this).Put_Stock_Participation_Rate_TableAsync(new Put_Stock_Participation_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Stock_Participation_Rate_Table_Request = Put_Stock_Participation_Rate_Table_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Stock_Participation_Rate_TablesOutput CompensationPort.Get_Stock_Participation_Rate_Tables(Get_Stock_Participation_Rate_TablesInput request)
		{
			return base.Channel.Get_Stock_Participation_Rate_Tables(request);
		}

		public Get_Stock_Participation_Rate_Tables_ResponseType Get_Stock_Participation_Rate_Tables(Workday_Common_HeaderType Workday_Common_Header, Get_Stock_Participation_Rate_Tables_RequestType Get_Stock_Participation_Rate_Tables_Request)
		{
			return ((CompensationPort)this).Get_Stock_Participation_Rate_Tables(new Get_Stock_Participation_Rate_TablesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Stock_Participation_Rate_Tables_Request = Get_Stock_Participation_Rate_Tables_Request
			}).Get_Stock_Participation_Rate_Tables_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Stock_Participation_Rate_TablesOutput> CompensationPort.Get_Stock_Participation_Rate_TablesAsync(Get_Stock_Participation_Rate_TablesInput request)
		{
			return base.Channel.Get_Stock_Participation_Rate_TablesAsync(request);
		}

		public Task<Get_Stock_Participation_Rate_TablesOutput> Get_Stock_Participation_Rate_TablesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Stock_Participation_Rate_Tables_RequestType Get_Stock_Participation_Rate_Tables_Request)
		{
			return ((CompensationPort)this).Get_Stock_Participation_Rate_TablesAsync(new Get_Stock_Participation_Rate_TablesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Stock_Participation_Rate_Tables_Request = Get_Stock_Participation_Rate_Tables_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OneTime_Payment_Plan_Configurable_CategoriesOutput CompensationPort.Get_OneTime_Payment_Plan_Configurable_Categories(Get_OneTime_Payment_Plan_Configurable_CategoriesInput request)
		{
			return base.Channel.Get_OneTime_Payment_Plan_Configurable_Categories(request);
		}

		public Get_OneTime_Payment_Plan_Configurable_Categories_ResponseType Get_OneTime_Payment_Plan_Configurable_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_OneTime_Payment_Plan_Configurable_Categories_RequestType Get_OneTime_Payment_Plan_Configurable_Categories_Request)
		{
			return ((CompensationPort)this).Get_OneTime_Payment_Plan_Configurable_Categories(new Get_OneTime_Payment_Plan_Configurable_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_OneTime_Payment_Plan_Configurable_Categories_Request = Get_OneTime_Payment_Plan_Configurable_Categories_Request
			}).Get_OneTime_Payment_Plan_Configurable_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OneTime_Payment_Plan_Configurable_CategoriesOutput> CompensationPort.Get_OneTime_Payment_Plan_Configurable_CategoriesAsync(Get_OneTime_Payment_Plan_Configurable_CategoriesInput request)
		{
			return base.Channel.Get_OneTime_Payment_Plan_Configurable_CategoriesAsync(request);
		}

		public Task<Get_OneTime_Payment_Plan_Configurable_CategoriesOutput> Get_OneTime_Payment_Plan_Configurable_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_OneTime_Payment_Plan_Configurable_Categories_RequestType Get_OneTime_Payment_Plan_Configurable_Categories_Request)
		{
			return ((CompensationPort)this).Get_OneTime_Payment_Plan_Configurable_CategoriesAsync(new Get_OneTime_Payment_Plan_Configurable_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_OneTime_Payment_Plan_Configurable_Categories_Request = Get_OneTime_Payment_Plan_Configurable_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_OneTime_Payment_Plan_Configurable_CategoryOutput CompensationPort.Put_OneTime_Payment_Plan_Configurable_Category(Put_OneTime_Payment_Plan_Configurable_CategoryInput request)
		{
			return base.Channel.Put_OneTime_Payment_Plan_Configurable_Category(request);
		}

		public Put_OneTime_Payment_Plan_Configurable_Category_ResponseType Put_OneTime_Payment_Plan_Configurable_Category(Workday_Common_HeaderType Workday_Common_Header, Put_OneTime_Payment_Plan_Configurable_Category_RequestType Put_OneTime_Payment_Plan_Configurable_Category_Request)
		{
			return ((CompensationPort)this).Put_OneTime_Payment_Plan_Configurable_Category(new Put_OneTime_Payment_Plan_Configurable_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_OneTime_Payment_Plan_Configurable_Category_Request = Put_OneTime_Payment_Plan_Configurable_Category_Request
			}).Put_OneTime_Payment_Plan_Configurable_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_OneTime_Payment_Plan_Configurable_CategoryOutput> CompensationPort.Put_OneTime_Payment_Plan_Configurable_CategoryAsync(Put_OneTime_Payment_Plan_Configurable_CategoryInput request)
		{
			return base.Channel.Put_OneTime_Payment_Plan_Configurable_CategoryAsync(request);
		}

		public Task<Put_OneTime_Payment_Plan_Configurable_CategoryOutput> Put_OneTime_Payment_Plan_Configurable_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_OneTime_Payment_Plan_Configurable_Category_RequestType Put_OneTime_Payment_Plan_Configurable_Category_Request)
		{
			return ((CompensationPort)this).Put_OneTime_Payment_Plan_Configurable_CategoryAsync(new Put_OneTime_Payment_Plan_Configurable_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_OneTime_Payment_Plan_Configurable_Category_Request = Put_OneTime_Payment_Plan_Configurable_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Request_Requisition_Compensation_ChangeOutput CompensationPort.Request_Requisition_Compensation_Change(Request_Requisition_Compensation_ChangeInput request)
		{
			return base.Channel.Request_Requisition_Compensation_Change(request);
		}

		public Request_Requisition_Compensation_Change_ResponseType Request_Requisition_Compensation_Change(Workday_Common_HeaderType Workday_Common_Header, Request_Requisition_Compensation_Change_RequestType Request_Requisition_Compensation_Change_Request)
		{
			return ((CompensationPort)this).Request_Requisition_Compensation_Change(new Request_Requisition_Compensation_ChangeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Requisition_Compensation_Change_Request = Request_Requisition_Compensation_Change_Request
			}).Request_Requisition_Compensation_Change_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Request_Requisition_Compensation_ChangeOutput> CompensationPort.Request_Requisition_Compensation_ChangeAsync(Request_Requisition_Compensation_ChangeInput request)
		{
			return base.Channel.Request_Requisition_Compensation_ChangeAsync(request);
		}

		public Task<Request_Requisition_Compensation_ChangeOutput> Request_Requisition_Compensation_ChangeAsync(Workday_Common_HeaderType Workday_Common_Header, Request_Requisition_Compensation_Change_RequestType Request_Requisition_Compensation_Change_Request)
		{
			return ((CompensationPort)this).Request_Requisition_Compensation_ChangeAsync(new Request_Requisition_Compensation_ChangeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Requisition_Compensation_Change_Request = Request_Requisition_Compensation_Change_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Eligible_Earnings_OverrideOutput CompensationPort.Import_Eligible_Earnings_Override(Import_Eligible_Earnings_OverrideInput request)
		{
			return base.Channel.Import_Eligible_Earnings_Override(request);
		}

		public Put_Import_Process_ResponseType Import_Eligible_Earnings_Override(Workday_Common_HeaderType Workday_Common_Header, Import_Eligible_Earnings_Override_RequestType Import_Eligible_Earnings_Override_Request)
		{
			return ((CompensationPort)this).Import_Eligible_Earnings_Override(new Import_Eligible_Earnings_OverrideInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Eligible_Earnings_Override_Request = Import_Eligible_Earnings_Override_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Eligible_Earnings_OverrideOutput> CompensationPort.Import_Eligible_Earnings_OverrideAsync(Import_Eligible_Earnings_OverrideInput request)
		{
			return base.Channel.Import_Eligible_Earnings_OverrideAsync(request);
		}

		public Task<Import_Eligible_Earnings_OverrideOutput> Import_Eligible_Earnings_OverrideAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Eligible_Earnings_Override_RequestType Import_Eligible_Earnings_Override_Request)
		{
			return ((CompensationPort)this).Import_Eligible_Earnings_OverrideAsync(new Import_Eligible_Earnings_OverrideInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Eligible_Earnings_Override_Request = Import_Eligible_Earnings_Override_Request
			});
		}
	}
}
