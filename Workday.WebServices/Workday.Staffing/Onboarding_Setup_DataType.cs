using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Onboarding_Setup_DataType : INotifyPropertyChanged
	{
		private Onboarding_Setup_TemplateObjectType onboarding_Setup_Template_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Onboarding_Setup_TemplateObjectType Onboarding_Setup_Template_Reference
		{
			get
			{
				return this.onboarding_Setup_Template_ReferenceField;
			}
			set
			{
				this.onboarding_Setup_Template_ReferenceField = value;
				this.RaisePropertyChanged("Onboarding_Setup_Template_Reference");
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
