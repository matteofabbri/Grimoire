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
	public class Marketing_Activity_DefinitionType : INotifyPropertyChanged
	{
		private Marketing_Activity_DefinitionObjectType marketing_Activity_Definition_ReferenceField;

		private Marketing_Activity_Definition_DataType[] marketing_Activity_Definition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Marketing_Activity_DefinitionObjectType Marketing_Activity_Definition_Reference
		{
			get
			{
				return this.marketing_Activity_Definition_ReferenceField;
			}
			set
			{
				this.marketing_Activity_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Marketing_Activity_Definition_Reference");
			}
		}

		[XmlElement("Marketing_Activity_Definition_Data", Order = 1)]
		public Marketing_Activity_Definition_DataType[] Marketing_Activity_Definition_Data
		{
			get
			{
				return this.marketing_Activity_Definition_DataField;
			}
			set
			{
				this.marketing_Activity_Definition_DataField = value;
				this.RaisePropertyChanged("Marketing_Activity_Definition_Data");
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
