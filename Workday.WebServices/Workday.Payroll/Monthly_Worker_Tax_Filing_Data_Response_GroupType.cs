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
	public class Monthly_Worker_Tax_Filing_Data_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_YTD_DataField;

		private bool include_YTD_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_YTD_Data
		{
			get
			{
				return this.include_YTD_DataField;
			}
			set
			{
				this.include_YTD_DataField = value;
				this.RaisePropertyChanged("Include_YTD_Data");
			}
		}

		[XmlIgnore]
		public bool Include_YTD_DataSpecified
		{
			get
			{
				return this.include_YTD_DataFieldSpecified;
			}
			set
			{
				this.include_YTD_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_YTD_DataSpecified");
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
