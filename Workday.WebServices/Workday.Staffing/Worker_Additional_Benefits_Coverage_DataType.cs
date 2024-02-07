using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Additional_Benefits_Coverage_DataType : INotifyPropertyChanged
	{
		private Additional_Benefits_Coverage_TargetObjectType additional_Benefits_Coverage_Target_ReferenceField;

		private DateTime original_Coverage_Begin_Date_for_Coverage_TargetField;

		private bool original_Coverage_Begin_Date_for_Coverage_TargetFieldSpecified;

		private Worker_Benefit_Election_DataType benefit_Election_DataField;

		private Employee_Contribution_Percentage_DataType percent_Contribution_DataField;

		private Employee_Contribution_Amount_DataType[] amount_Contribution_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Additional_Benefits_Coverage_TargetObjectType Additional_Benefits_Coverage_Target_Reference
		{
			get
			{
				return this.additional_Benefits_Coverage_Target_ReferenceField;
			}
			set
			{
				this.additional_Benefits_Coverage_Target_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Benefits_Coverage_Target_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Original_Coverage_Begin_Date_for_Coverage_Target
		{
			get
			{
				return this.original_Coverage_Begin_Date_for_Coverage_TargetField;
			}
			set
			{
				this.original_Coverage_Begin_Date_for_Coverage_TargetField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date_for_Coverage_Target");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_Date_for_Coverage_TargetSpecified
		{
			get
			{
				return this.original_Coverage_Begin_Date_for_Coverage_TargetFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_Date_for_Coverage_TargetFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date_for_Coverage_TargetSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Worker_Benefit_Election_DataType Benefit_Election_Data
		{
			get
			{
				return this.benefit_Election_DataField;
			}
			set
			{
				this.benefit_Election_DataField = value;
				this.RaisePropertyChanged("Benefit_Election_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Employee_Contribution_Percentage_DataType Percent_Contribution_Data
		{
			get
			{
				return this.percent_Contribution_DataField;
			}
			set
			{
				this.percent_Contribution_DataField = value;
				this.RaisePropertyChanged("Percent_Contribution_Data");
			}
		}

		[XmlElement("Amount_Contribution_Data", Order = 4)]
		public Employee_Contribution_Amount_DataType[] Amount_Contribution_Data
		{
			get
			{
				return this.amount_Contribution_DataField;
			}
			set
			{
				this.amount_Contribution_DataField = value;
				this.RaisePropertyChanged("Amount_Contribution_Data");
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
