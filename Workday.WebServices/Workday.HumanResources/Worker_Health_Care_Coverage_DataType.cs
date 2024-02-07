using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Health_Care_Coverage_DataType : INotifyPropertyChanged
	{
		private Health_Care_Coverage_TargetObjectType health_Care_Coverage_Target_ReferenceField;

		private DateTime original_Coverage_Begin_Date_for_Coverage_TargetField;

		private bool original_Coverage_Begin_Date_for_Coverage_TargetFieldSpecified;

		private string provider_IDField;

		private Worker_Benefit_Election_DataType benefit_Election_DataField;

		private Dependent_Coverage_DataType[] dependent_Coverage_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Health_Care_Coverage_TargetObjectType Health_Care_Coverage_Target_Reference
		{
			get
			{
				return this.health_Care_Coverage_Target_ReferenceField;
			}
			set
			{
				this.health_Care_Coverage_Target_ReferenceField = value;
				this.RaisePropertyChanged("Health_Care_Coverage_Target_Reference");
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
		public string Provider_ID
		{
			get
			{
				return this.provider_IDField;
			}
			set
			{
				this.provider_IDField = value;
				this.RaisePropertyChanged("Provider_ID");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Dependent_Coverage_Data", Order = 4)]
		public Dependent_Coverage_DataType[] Dependent_Coverage_Data
		{
			get
			{
				return this.dependent_Coverage_DataField;
			}
			set
			{
				this.dependent_Coverage_DataField = value;
				this.RaisePropertyChanged("Dependent_Coverage_Data");
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
