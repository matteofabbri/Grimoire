using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Project-Based_Order_Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ProjectBased_Order_Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType : INotifyPropertyChanged
	{
		private bool purchase_Order_Line_CanceledField;

		private bool purchase_Order_Line_CanceledFieldSpecified;

		private ProjectObjectType project_ReferenceField;

		private Project_Plan_TaskObjectType[] project_Activities_ReferenceField;

		private DateTime state_DateField;

		private bool state_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal uNSPSC_CodeField;

		private bool uNSPSC_CodeFieldSpecified;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Purchase_Order_Line_Canceled
		{
			get
			{
				return this.purchase_Order_Line_CanceledField;
			}
			set
			{
				this.purchase_Order_Line_CanceledField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Canceled");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Line_CanceledSpecified
		{
			get
			{
				return this.purchase_Order_Line_CanceledFieldSpecified;
			}
			set
			{
				this.purchase_Order_Line_CanceledFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Line_CanceledSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public ProjectObjectType Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement("Project_Activities_Reference", Order = 2)]
		public Project_Plan_TaskObjectType[] Project_Activities_Reference
		{
			get
			{
				return this.project_Activities_ReferenceField;
			}
			set
			{
				this.project_Activities_ReferenceField = value;
				this.RaisePropertyChanged("Project_Activities_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime State_Date
		{
			get
			{
				return this.state_DateField;
			}
			set
			{
				this.state_DateField = value;
				this.RaisePropertyChanged("State_Date");
			}
		}

		[XmlIgnore]
		public bool State_DateSpecified
		{
			get
			{
				return this.state_DateFieldSpecified;
			}
			set
			{
				this.state_DateFieldSpecified = value;
				this.RaisePropertyChanged("State_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal UNSPSC_Code
		{
			get
			{
				return this.uNSPSC_CodeField;
			}
			set
			{
				this.uNSPSC_CodeField = value;
				this.RaisePropertyChanged("UNSPSC_Code");
			}
		}

		[XmlIgnore]
		public bool UNSPSC_CodeSpecified
		{
			get
			{
				return this.uNSPSC_CodeFieldSpecified;
			}
			set
			{
				this.uNSPSC_CodeFieldSpecified = value;
				this.RaisePropertyChanged("UNSPSC_CodeSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
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
