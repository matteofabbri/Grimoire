using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Report_Background_Future_Process_as_Custom_Report_DataType : INotifyPropertyChanged
	{
		private Custom_Report_DefinitionObjectType custom_Report_Definition_ReferenceField;

		private Unique_IdentifierObjectType output_Format_ReferenceField;

		private System_UserObjectType run_As_System_User_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Custom_Report_DefinitionObjectType Custom_Report_Definition_Reference
		{
			get
			{
				return this.custom_Report_Definition_ReferenceField;
			}
			set
			{
				this.custom_Report_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Report_Definition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Output_Format_Reference
		{
			get
			{
				return this.output_Format_ReferenceField;
			}
			set
			{
				this.output_Format_ReferenceField = value;
				this.RaisePropertyChanged("Output_Format_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public System_UserObjectType Run_As_System_User_Reference
		{
			get
			{
				return this.run_As_System_User_ReferenceField;
			}
			set
			{
				this.run_As_System_User_ReferenceField = value;
				this.RaisePropertyChanged("Run_As_System_User_Reference");
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
