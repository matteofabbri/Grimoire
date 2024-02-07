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
	public class Procurement_Mass_CloseType : INotifyPropertyChanged
	{
		private Procurement_Mass_CloseObjectType procurement_Mass_Close_ReferenceField;

		private Procurement_Mass_Close_DataType procurement_Mass_Close_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Procurement_Mass_CloseObjectType Procurement_Mass_Close_Reference
		{
			get
			{
				return this.procurement_Mass_Close_ReferenceField;
			}
			set
			{
				this.procurement_Mass_Close_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Procurement_Mass_Close_DataType Procurement_Mass_Close_Data
		{
			get
			{
				return this.procurement_Mass_Close_DataField;
			}
			set
			{
				this.procurement_Mass_Close_DataField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_Data");
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
