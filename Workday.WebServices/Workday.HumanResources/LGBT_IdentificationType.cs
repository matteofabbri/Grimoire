using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class LGBT_IdentificationType : INotifyPropertyChanged
	{
		private LGBT_IdentificationObjectType lGBT_Identification_ReferenceField;

		private LGBT_Identification_DataType lGBT_Identification_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LGBT_IdentificationObjectType LGBT_Identification_Reference
		{
			get
			{
				return this.lGBT_Identification_ReferenceField;
			}
			set
			{
				this.lGBT_Identification_ReferenceField = value;
				this.RaisePropertyChanged("LGBT_Identification_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public LGBT_Identification_DataType LGBT_Identification_Data
		{
			get
			{
				return this.lGBT_Identification_DataField;
			}
			set
			{
				this.lGBT_Identification_DataField = value;
				this.RaisePropertyChanged("LGBT_Identification_Data");
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
