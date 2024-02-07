using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Activity_Task_Request_CriteriaType : INotifyPropertyChanged
	{
		private bool include_InactiveField;

		private bool include_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Inactive
		{
			get
			{
				return this.include_InactiveField;
			}
			set
			{
				this.include_InactiveField = value;
				this.RaisePropertyChanged("Include_Inactive");
			}
		}

		[XmlIgnore]
		public bool Include_InactiveSpecified
		{
			get
			{
				return this.include_InactiveFieldSpecified;
			}
			set
			{
				this.include_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Include_InactiveSpecified");
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
