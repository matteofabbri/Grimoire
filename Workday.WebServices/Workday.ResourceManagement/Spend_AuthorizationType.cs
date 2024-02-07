using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Spend_AuthorizationType : INotifyPropertyChanged
	{
		private Spend_AuthorizationObjectType spend_Authorization_ReferenceField;

		private Spend_Authorization_DataType[] spend_Authorization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Spend_AuthorizationObjectType Spend_Authorization_Reference
		{
			get
			{
				return this.spend_Authorization_ReferenceField;
			}
			set
			{
				this.spend_Authorization_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Authorization_Reference");
			}
		}

		[XmlElement("Spend_Authorization_Data", Order = 1)]
		public Spend_Authorization_DataType[] Spend_Authorization_Data
		{
			get
			{
				return this.spend_Authorization_DataField;
			}
			set
			{
				this.spend_Authorization_DataField = value;
				this.RaisePropertyChanged("Spend_Authorization_Data");
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
