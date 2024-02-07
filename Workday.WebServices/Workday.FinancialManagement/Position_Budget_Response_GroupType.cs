using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Position_Budget_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferencesField;

		private bool include_ReferencesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_References
		{
			get
			{
				return this.include_ReferencesField;
			}
			set
			{
				this.include_ReferencesField = value;
				this.RaisePropertyChanged("Include_References");
			}
		}

		[XmlIgnore]
		public bool Include_ReferencesSpecified
		{
			get
			{
				return this.include_ReferencesFieldSpecified;
			}
			set
			{
				this.include_ReferencesFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferencesSpecified");
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
