using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Financials_Business_Sub_Process_ParametersType : INotifyPropertyChanged
	{
		private bool skipField;

		private bool skipFieldSpecified;

		private Business_Process_Comment_DataType business_Process_Comment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Skip
		{
			get
			{
				return this.skipField;
			}
			set
			{
				this.skipField = value;
				this.RaisePropertyChanged("Skip");
			}
		}

		[XmlIgnore]
		public bool SkipSpecified
		{
			get
			{
				return this.skipFieldSpecified;
			}
			set
			{
				this.skipFieldSpecified = value;
				this.RaisePropertyChanged("SkipSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Business_Process_Comment_DataType Business_Process_Comment_Data
		{
			get
			{
				return this.business_Process_Comment_DataField;
			}
			set
			{
				this.business_Process_Comment_DataField = value;
				this.RaisePropertyChanged("Business_Process_Comment_Data");
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
