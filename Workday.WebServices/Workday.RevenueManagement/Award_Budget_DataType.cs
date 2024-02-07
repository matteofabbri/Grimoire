using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Budget_DataType : INotifyPropertyChanged
	{
		private Budget_StructureObjectType default_Budget_Structure_ReferenceField;

		private Budget_TypeObjectType default_Budget_Type_ReferenceField;

		private bool default_Balanced_AmendmentField;

		private bool default_Balanced_AmendmentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Budget_StructureObjectType Default_Budget_Structure_Reference
		{
			get
			{
				return this.default_Budget_Structure_ReferenceField;
			}
			set
			{
				this.default_Budget_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Default_Budget_Structure_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Budget_TypeObjectType Default_Budget_Type_Reference
		{
			get
			{
				return this.default_Budget_Type_ReferenceField;
			}
			set
			{
				this.default_Budget_Type_ReferenceField = value;
				this.RaisePropertyChanged("Default_Budget_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Default_Balanced_Amendment
		{
			get
			{
				return this.default_Balanced_AmendmentField;
			}
			set
			{
				this.default_Balanced_AmendmentField = value;
				this.RaisePropertyChanged("Default_Balanced_Amendment");
			}
		}

		[XmlIgnore]
		public bool Default_Balanced_AmendmentSpecified
		{
			get
			{
				return this.default_Balanced_AmendmentFieldSpecified;
			}
			set
			{
				this.default_Balanced_AmendmentFieldSpecified = value;
				this.RaisePropertyChanged("Default_Balanced_AmendmentSpecified");
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
