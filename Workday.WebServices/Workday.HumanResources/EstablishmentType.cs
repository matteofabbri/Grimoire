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
	public class EstablishmentType : INotifyPropertyChanged
	{
		private EstablishmentObjectType establishment_ReferenceField;

		private Establishment_DataType[] establishment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EstablishmentObjectType Establishment_Reference
		{
			get
			{
				return this.establishment_ReferenceField;
			}
			set
			{
				this.establishment_ReferenceField = value;
				this.RaisePropertyChanged("Establishment_Reference");
			}
		}

		[XmlElement("Establishment_Data", Order = 1)]
		public Establishment_DataType[] Establishment_Data
		{
			get
			{
				return this.establishment_DataField;
			}
			set
			{
				this.establishment_DataField = value;
				this.RaisePropertyChanged("Establishment_Data");
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
