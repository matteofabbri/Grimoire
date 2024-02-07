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
	public class GrantType : INotifyPropertyChanged
	{
		private GrantObjectType grant_ReferenceField;

		private Grant_DataType[] grant_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public GrantObjectType Grant_Reference
		{
			get
			{
				return this.grant_ReferenceField;
			}
			set
			{
				this.grant_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Reference");
			}
		}

		[XmlElement("Grant_Data", Order = 1)]
		public Grant_DataType[] Grant_Data
		{
			get
			{
				return this.grant_DataField;
			}
			set
			{
				this.grant_DataField = value;
				this.RaisePropertyChanged("Grant_Data");
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
