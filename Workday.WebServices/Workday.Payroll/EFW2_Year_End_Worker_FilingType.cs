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
	public class EFW2_Year_End_Worker_FilingType : INotifyPropertyChanged
	{
		private string w2_Instance_IDField;

		private DateTime completed_MomentField;

		private bool completed_MomentFieldSpecified;

		private EFW2_Year_End_Worker_Filing_DataType eFW2_Year_End_Worker_Filing_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("W-2_Instance_ID", Order = 0)]
		public string W2_Instance_ID
		{
			get
			{
				return this.w2_Instance_IDField;
			}
			set
			{
				this.w2_Instance_IDField = value;
				this.RaisePropertyChanged("W2_Instance_ID");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Completed_Moment
		{
			get
			{
				return this.completed_MomentField;
			}
			set
			{
				this.completed_MomentField = value;
				this.RaisePropertyChanged("Completed_Moment");
			}
		}

		[XmlIgnore]
		public bool Completed_MomentSpecified
		{
			get
			{
				return this.completed_MomentFieldSpecified;
			}
			set
			{
				this.completed_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Completed_MomentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public EFW2_Year_End_Worker_Filing_DataType EFW2_Year_End_Worker_Filing_Data
		{
			get
			{
				return this.eFW2_Year_End_Worker_Filing_DataField;
			}
			set
			{
				this.eFW2_Year_End_Worker_Filing_DataField = value;
				this.RaisePropertyChanged("EFW2_Year_End_Worker_Filing_Data");
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
