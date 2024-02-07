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
	public class Gender_IdentityType : INotifyPropertyChanged
	{
		private Gender_IdentityObjectType gender_Identity_ReferenceField;

		private Gender_Identity_DataType[] gender_Identity_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Gender_IdentityObjectType Gender_Identity_Reference
		{
			get
			{
				return this.gender_Identity_ReferenceField;
			}
			set
			{
				this.gender_Identity_ReferenceField = value;
				this.RaisePropertyChanged("Gender_Identity_Reference");
			}
		}

		[XmlElement("Gender_Identity_Data", Order = 1)]
		public Gender_Identity_DataType[] Gender_Identity_Data
		{
			get
			{
				return this.gender_Identity_DataField;
			}
			set
			{
				this.gender_Identity_DataField = value;
				this.RaisePropertyChanged("Gender_Identity_Data");
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
