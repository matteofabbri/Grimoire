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
	public class Company_Response_GroupType : INotifyPropertyChanged
	{
		private bool oX_OnlyField;

		private bool oX_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool OX_Only
		{
			get
			{
				return this.oX_OnlyField;
			}
			set
			{
				this.oX_OnlyField = value;
				this.RaisePropertyChanged("OX_Only");
			}
		}

		[XmlIgnore]
		public bool OX_OnlySpecified
		{
			get
			{
				return this.oX_OnlyFieldSpecified;
			}
			set
			{
				this.oX_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("OX_OnlySpecified");
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
