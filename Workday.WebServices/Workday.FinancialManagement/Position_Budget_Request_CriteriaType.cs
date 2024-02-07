using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Position_Budget_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Budget_StructureObjectType business_Plan_Structure_ReferenceField;

		private Fiscal_YearObjectType fiscal_Year_ReferenceField;

		private Position_RestrictionsObjectType[] position_ReferenceField;

		private WorkerObjectType[] employee_ReferenceField;

		private Document_StatusObjectType[] version_Status_ReferenceField;

		private Position_Budget_Group_EventObjectType position_Budget_Group_Load_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Budget_StructureObjectType Business_Plan_Structure_Reference
		{
			get
			{
				return this.business_Plan_Structure_ReferenceField;
			}
			set
			{
				this.business_Plan_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Business_Plan_Structure_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Fiscal_YearObjectType Fiscal_Year_Reference
		{
			get
			{
				return this.fiscal_Year_ReferenceField;
			}
			set
			{
				this.fiscal_Year_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Year_Reference");
			}
		}

		[XmlElement("Position_Reference", Order = 3)]
		public Position_RestrictionsObjectType[] Position_Reference
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

		[XmlElement("Employee_Reference", Order = 4)]
		public WorkerObjectType[] Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement("Version_Status_Reference", Order = 5)]
		public Document_StatusObjectType[] Version_Status_Reference
		{
			get
			{
				return this.version_Status_ReferenceField;
			}
			set
			{
				this.version_Status_ReferenceField = value;
				this.RaisePropertyChanged("Version_Status_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Position_Budget_Group_EventObjectType Position_Budget_Group_Load_Reference
		{
			get
			{
				return this.position_Budget_Group_Load_ReferenceField;
			}
			set
			{
				this.position_Budget_Group_Load_ReferenceField = value;
				this.RaisePropertyChanged("Position_Budget_Group_Load_Reference");
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
