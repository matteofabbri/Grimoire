using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Financials_Business_Process_ParametersType : INotifyPropertyChanged
	{
		private bool auto_CompleteField;

		private bool auto_CompleteFieldSpecified;

		private Business_Process_Comment_DataType comment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Auto_Complete
		{
			get
			{
				return this.auto_CompleteField;
			}
			set
			{
				this.auto_CompleteField = value;
				this.RaisePropertyChanged("Auto_Complete");
			}
		}

		[XmlIgnore]
		public bool Auto_CompleteSpecified
		{
			get
			{
				return this.auto_CompleteFieldSpecified;
			}
			set
			{
				this.auto_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Auto_CompleteSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Business_Process_Comment_DataType Comment_Data
		{
			get
			{
				return this.comment_DataField;
			}
			set
			{
				this.comment_DataField = value;
				this.RaisePropertyChanged("Comment_Data");
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
