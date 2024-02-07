using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Search_Service_DefinitionType : INotifyPropertyChanged
	{
		private Search_Service_DefinitionObjectType search_Service_Definition_ReferenceField;

		private Search_Service_Definition_DataType search_Service_Definition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Search_Service_DefinitionObjectType Search_Service_Definition_Reference
		{
			get
			{
				return this.search_Service_Definition_ReferenceField;
			}
			set
			{
				this.search_Service_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Search_Service_Definition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Search_Service_Definition_DataType Search_Service_Definition_Data
		{
			get
			{
				return this.search_Service_Definition_DataField;
			}
			set
			{
				this.search_Service_Definition_DataField = value;
				this.RaisePropertyChanged("Search_Service_Definition_Data");
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
