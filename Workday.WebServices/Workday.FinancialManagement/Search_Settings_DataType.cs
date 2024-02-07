using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Search_Settings_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] object_Type_to_Suppress_from_Search_ReferenceField;

		private Synonym_Webservice_DataType[] synonymsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Object_Type_to_Suppress_from_Search_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Object_Type_to_Suppress_from_Search_Reference
		{
			get
			{
				return this.object_Type_to_Suppress_from_Search_ReferenceField;
			}
			set
			{
				this.object_Type_to_Suppress_from_Search_ReferenceField = value;
				this.RaisePropertyChanged("Object_Type_to_Suppress_from_Search_Reference");
			}
		}

		[XmlElement("Synonyms", Order = 1)]
		public Synonym_Webservice_DataType[] Synonyms
		{
			get
			{
				return this.synonymsField;
			}
			set
			{
				this.synonymsField = value;
				this.RaisePropertyChanged("Synonyms");
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
