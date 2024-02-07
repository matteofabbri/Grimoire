using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Time_Off_DataType : INotifyPropertyChanged
	{
		private Time_Off__All_ObjectType time_Off_ReferenceField;

		private Time_Off_TypeObjectType time_Off_Type_ReferenceField;

		private Unit_of_TimeObjectType unit_of_Time_ReferenceField;

		private Payee_Time_Off_Detail_DataType[] time_Off_Detail_DataField;

		private Payee_Time_Off_Entries_Detail_DataType[] time_Off_Entries_Detail_DataField;

		private Payee_Time_Off_Corrected_DataType[] time_Off_Corrected_DataField;

		private Time_Off_Adjustment_Payroll_CorrectionType[] time_Off_Adjustment_Payroll_CorrectionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Time_Off__All_ObjectType Time_Off_Reference
		{
			get
			{
				return this.time_Off_ReferenceField;
			}
			set
			{
				this.time_Off_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Time_Off_TypeObjectType Time_Off_Type_Reference
		{
			get
			{
				return this.time_Off_Type_ReferenceField;
			}
			set
			{
				this.time_Off_Type_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Unit_of_TimeObjectType Unit_of_Time_Reference
		{
			get
			{
				return this.unit_of_Time_ReferenceField;
			}
			set
			{
				this.unit_of_Time_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Time_Reference");
			}
		}

		[XmlElement("Time_Off_Detail_Data", Order = 3)]
		public Payee_Time_Off_Detail_DataType[] Time_Off_Detail_Data
		{
			get
			{
				return this.time_Off_Detail_DataField;
			}
			set
			{
				this.time_Off_Detail_DataField = value;
				this.RaisePropertyChanged("Time_Off_Detail_Data");
			}
		}

		[XmlElement("Time_Off_Entries_Detail_Data", Order = 4)]
		public Payee_Time_Off_Entries_Detail_DataType[] Time_Off_Entries_Detail_Data
		{
			get
			{
				return this.time_Off_Entries_Detail_DataField;
			}
			set
			{
				this.time_Off_Entries_Detail_DataField = value;
				this.RaisePropertyChanged("Time_Off_Entries_Detail_Data");
			}
		}

		[XmlElement("Time_Off_Corrected_Data", Order = 5)]
		public Payee_Time_Off_Corrected_DataType[] Time_Off_Corrected_Data
		{
			get
			{
				return this.time_Off_Corrected_DataField;
			}
			set
			{
				this.time_Off_Corrected_DataField = value;
				this.RaisePropertyChanged("Time_Off_Corrected_Data");
			}
		}

		[XmlElement("Time_Off_Adjustment_Payroll_Correction", Order = 6)]
		public Time_Off_Adjustment_Payroll_CorrectionType[] Time_Off_Adjustment_Payroll_Correction
		{
			get
			{
				return this.time_Off_Adjustment_Payroll_CorrectionField;
			}
			set
			{
				this.time_Off_Adjustment_Payroll_CorrectionField = value;
				this.RaisePropertyChanged("Time_Off_Adjustment_Payroll_Correction");
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
