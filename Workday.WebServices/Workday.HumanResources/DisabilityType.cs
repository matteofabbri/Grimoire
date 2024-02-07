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
	public class DisabilityType : INotifyPropertyChanged
	{
		private DisabilityObjectType disability_ReferenceField;

		private Disability_DataType disability_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DisabilityObjectType Disability_Reference
		{
			get
			{
				return this.disability_ReferenceField;
			}
			set
			{
				this.disability_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Disability_DataType Disability_Data
		{
			get
			{
				return this.disability_DataField;
			}
			set
			{
				this.disability_DataField = value;
				this.RaisePropertyChanged("Disability_Data");
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
