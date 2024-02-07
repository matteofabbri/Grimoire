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
	public class Integration_Document_Stack_DataType : INotifyPropertyChanged
	{
		private decimal stack_LevelField;

		private Integration_Document_FieldObjectType integration_Document_Field_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Stack_Level
		{
			get
			{
				return this.stack_LevelField;
			}
			set
			{
				this.stack_LevelField = value;
				this.RaisePropertyChanged("Stack_Level");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_Document_FieldObjectType Integration_Document_Field_Reference
		{
			get
			{
				return this.integration_Document_Field_ReferenceField;
			}
			set
			{
				this.integration_Document_Field_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Document_Field_Reference");
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
