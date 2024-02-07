using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Edit_Dependent_DataType : INotifyPropertyChanged
	{
		private DependentObjectType dependent_ReferenceField;

		private Edit_Dependent_Event_DataType edit_Dependent_Event_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DependentObjectType Dependent_Reference
		{
			get
			{
				return this.dependent_ReferenceField;
			}
			set
			{
				this.dependent_ReferenceField = value;
				this.RaisePropertyChanged("Dependent_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Edit_Dependent_Event_DataType Edit_Dependent_Event_Data
		{
			get
			{
				return this.edit_Dependent_Event_DataField;
			}
			set
			{
				this.edit_Dependent_Event_DataField = value;
				this.RaisePropertyChanged("Edit_Dependent_Event_Data");
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
