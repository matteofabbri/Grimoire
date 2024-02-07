using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Worker_W-2PR_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_W2PR_DataType : INotifyPropertyChanged
	{
		private string w2PR_Instance_IDField;

		private DateTime completed_MomentField;

		private bool completed_MomentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("W-2PR_Instance_ID", Order = 0)]
		public string W2PR_Instance_ID
		{
			get
			{
				return this.w2PR_Instance_IDField;
			}
			set
			{
				this.w2PR_Instance_IDField = value;
				this.RaisePropertyChanged("W2PR_Instance_ID");
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
