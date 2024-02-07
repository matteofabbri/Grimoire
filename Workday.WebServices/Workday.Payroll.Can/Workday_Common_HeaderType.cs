using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workday_Common_HeaderType : INotifyPropertyChanged
	{
		private bool include_Reference_Descriptors_In_ResponseField;

		private bool include_Reference_Descriptors_In_ResponseFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference_Descriptors_In_Response
		{
			get
			{
				return this.include_Reference_Descriptors_In_ResponseField;
			}
			set
			{
				this.include_Reference_Descriptors_In_ResponseField = value;
				this.RaisePropertyChanged("Include_Reference_Descriptors_In_Response");
			}
		}

		[XmlIgnore]
		public bool Include_Reference_Descriptors_In_ResponseSpecified
		{
			get
			{
				return this.include_Reference_Descriptors_In_ResponseFieldSpecified;
			}
			set
			{
				this.include_Reference_Descriptors_In_ResponseFieldSpecified = value;
				this.RaisePropertyChanged("Include_Reference_Descriptors_In_ResponseSpecified");
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
