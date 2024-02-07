using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class SubspecialtyType : INotifyPropertyChanged
	{
		private Specialty_ChildObjectType subspecialty_ReferenceField;

		private Subspecialty_DataType[] subspecialty_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Specialty_ChildObjectType Subspecialty_Reference
		{
			get
			{
				return this.subspecialty_ReferenceField;
			}
			set
			{
				this.subspecialty_ReferenceField = value;
				this.RaisePropertyChanged("Subspecialty_Reference");
			}
		}

		[XmlElement("Subspecialty_Data", Order = 1)]
		public Subspecialty_DataType[] Subspecialty_Data
		{
			get
			{
				return this.subspecialty_DataField;
			}
			set
			{
				this.subspecialty_DataField = value;
				this.RaisePropertyChanged("Subspecialty_Data");
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
