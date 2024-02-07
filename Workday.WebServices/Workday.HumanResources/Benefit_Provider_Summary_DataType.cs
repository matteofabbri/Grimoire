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
	public class Benefit_Provider_Summary_DataType : INotifyPropertyChanged
	{
		private Benefit_ProviderObjectType benefit_Provider_ReferenceField;

		private string benefit_Provider_NameField;

		private Benefit_Provider_Identifier_TypeObjectType benefit_Provider_Identifier_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_ProviderObjectType Benefit_Provider_Reference
		{
			get
			{
				return this.benefit_Provider_ReferenceField;
			}
			set
			{
				this.benefit_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Provider_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Benefit_Provider_Name
		{
			get
			{
				return this.benefit_Provider_NameField;
			}
			set
			{
				this.benefit_Provider_NameField = value;
				this.RaisePropertyChanged("Benefit_Provider_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Benefit_Provider_Identifier_TypeObjectType Benefit_Provider_Identifier_Type_Reference
		{
			get
			{
				return this.benefit_Provider_Identifier_Type_ReferenceField;
			}
			set
			{
				this.benefit_Provider_Identifier_Type_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Provider_Identifier_Type_Reference");
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
