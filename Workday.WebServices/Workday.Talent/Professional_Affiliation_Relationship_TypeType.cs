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
	public class Professional_Affiliation_Relationship_TypeType : INotifyPropertyChanged
	{
		private Professional_Affiliation_Relationship_TypeObjectType professional_Affiliation_Relationship_Type_ReferenceField;

		private Professional_Affiliation_Relationship_Type_DataType[] professional_Affiliation_Relationship_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Professional_Affiliation_Relationship_TypeObjectType Professional_Affiliation_Relationship_Type_Reference
		{
			get
			{
				return this.professional_Affiliation_Relationship_Type_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_Relationship_Type_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Relationship_Type_Reference");
			}
		}

		[XmlElement("Professional_Affiliation_Relationship_Type_Data", Order = 1)]
		public Professional_Affiliation_Relationship_Type_DataType[] Professional_Affiliation_Relationship_Type_Data
		{
			get
			{
				return this.professional_Affiliation_Relationship_Type_DataField;
			}
			set
			{
				this.professional_Affiliation_Relationship_Type_DataField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Relationship_Type_Data");
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
