using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Run_Pay_Calculation_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_Process_Calculation_CriteriaField;

		private bool include_Process_Calculation_CriteriaFieldSpecified;

		private bool include_Pay_Groups_Being_CalculatedField;

		private bool include_Pay_Groups_Being_CalculatedFieldSpecified;

		private bool include_Process_InformationField;

		private bool include_Process_InformationFieldSpecified;

		private bool include_Process_HistoryField;

		private bool include_Process_HistoryFieldSpecified;

		private bool include_MessagesField;

		private bool include_MessagesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Process_Calculation_Criteria
		{
			get
			{
				return this.include_Process_Calculation_CriteriaField;
			}
			set
			{
				this.include_Process_Calculation_CriteriaField = value;
				this.RaisePropertyChanged("Include_Process_Calculation_Criteria");
			}
		}

		[XmlIgnore]
		public bool Include_Process_Calculation_CriteriaSpecified
		{
			get
			{
				return this.include_Process_Calculation_CriteriaFieldSpecified;
			}
			set
			{
				this.include_Process_Calculation_CriteriaFieldSpecified = value;
				this.RaisePropertyChanged("Include_Process_Calculation_CriteriaSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Pay_Groups_Being_Calculated
		{
			get
			{
				return this.include_Pay_Groups_Being_CalculatedField;
			}
			set
			{
				this.include_Pay_Groups_Being_CalculatedField = value;
				this.RaisePropertyChanged("Include_Pay_Groups_Being_Calculated");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Groups_Being_CalculatedSpecified
		{
			get
			{
				return this.include_Pay_Groups_Being_CalculatedFieldSpecified;
			}
			set
			{
				this.include_Pay_Groups_Being_CalculatedFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Groups_Being_CalculatedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Process_Information
		{
			get
			{
				return this.include_Process_InformationField;
			}
			set
			{
				this.include_Process_InformationField = value;
				this.RaisePropertyChanged("Include_Process_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Process_InformationSpecified
		{
			get
			{
				return this.include_Process_InformationFieldSpecified;
			}
			set
			{
				this.include_Process_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Process_InformationSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Process_History
		{
			get
			{
				return this.include_Process_HistoryField;
			}
			set
			{
				this.include_Process_HistoryField = value;
				this.RaisePropertyChanged("Include_Process_History");
			}
		}

		[XmlIgnore]
		public bool Include_Process_HistorySpecified
		{
			get
			{
				return this.include_Process_HistoryFieldSpecified;
			}
			set
			{
				this.include_Process_HistoryFieldSpecified = value;
				this.RaisePropertyChanged("Include_Process_HistorySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Messages
		{
			get
			{
				return this.include_MessagesField;
			}
			set
			{
				this.include_MessagesField = value;
				this.RaisePropertyChanged("Include_Messages");
			}
		}

		[XmlIgnore]
		public bool Include_MessagesSpecified
		{
			get
			{
				return this.include_MessagesFieldSpecified;
			}
			set
			{
				this.include_MessagesFieldSpecified = value;
				this.RaisePropertyChanged("Include_MessagesSpecified");
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
