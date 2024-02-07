using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Organization_Event_DataType : INotifyPropertyChanged
	{
		private Staffing_InterfaceObjectType position_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private OrganizationObjectType[] organization_ReferenceField;

		private FundObjectType[] fund_ReferenceField;

		private GrantObjectType[] grant_ReferenceField;

		private ProgramObjectType[] program_ReferenceField;

		private Business_UnitObjectType[] business_Unit_ReferenceField;

		private GiftObjectType[] gift_ReferenceField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private DateTime as_Of_Effective_DateField;

		private bool as_Of_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Staffing_InterfaceObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement("Organization_Reference", Order = 2)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Fund_Reference", Order = 3)]
		public FundObjectType[] Fund_Reference
		{
			get
			{
				return this.fund_ReferenceField;
			}
			set
			{
				this.fund_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Reference");
			}
		}

		[XmlElement("Grant_Reference", Order = 4)]
		public GrantObjectType[] Grant_Reference
		{
			get
			{
				return this.grant_ReferenceField;
			}
			set
			{
				this.grant_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Reference");
			}
		}

		[XmlElement("Program_Reference", Order = 5)]
		public ProgramObjectType[] Program_Reference
		{
			get
			{
				return this.program_ReferenceField;
			}
			set
			{
				this.program_ReferenceField = value;
				this.RaisePropertyChanged("Program_Reference");
			}
		}

		[XmlElement("Business_Unit_Reference", Order = 6)]
		public Business_UnitObjectType[] Business_Unit_Reference
		{
			get
			{
				return this.business_Unit_ReferenceField;
			}
			set
			{
				this.business_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Reference");
			}
		}

		[XmlElement("Gift_Reference", Order = 7)]
		public GiftObjectType[] Gift_Reference
		{
			get
			{
				return this.gift_ReferenceField;
			}
			set
			{
				this.gift_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Check_Position_Budget_Sub_Business_ProcessType Check_Position_Budget_Sub_Process
		{
			get
			{
				return this.check_Position_Budget_Sub_ProcessField;
			}
			set
			{
				this.check_Position_Budget_Sub_ProcessField = value;
				this.RaisePropertyChanged("Check_Position_Budget_Sub_Process");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime As_Of_Effective_Date
		{
			get
			{
				return this.as_Of_Effective_DateField;
			}
			set
			{
				this.as_Of_Effective_DateField = value;
				this.RaisePropertyChanged("As_Of_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool As_Of_Effective_DateSpecified
		{
			get
			{
				return this.as_Of_Effective_DateFieldSpecified;
			}
			set
			{
				this.as_Of_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_Effective_DateSpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
