using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Pay_ComponentType : INotifyPropertyChanged
	{
		private Pay_ComponentObjectType external_Pay_Component_ReferenceField;

		private External_Pay_Component_DataType[] external_Pay_Component_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_ComponentObjectType External_Pay_Component_Reference
		{
			get
			{
				return this.external_Pay_Component_ReferenceField;
			}
			set
			{
				this.external_Pay_Component_ReferenceField = value;
				this.RaisePropertyChanged("External_Pay_Component_Reference");
			}
		}

		[XmlElement("External_Pay_Component_Data", Order = 1)]
		public External_Pay_Component_DataType[] External_Pay_Component_Data
		{
			get
			{
				return this.external_Pay_Component_DataField;
			}
			set
			{
				this.external_Pay_Component_DataField = value;
				this.RaisePropertyChanged("External_Pay_Component_Data");
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
