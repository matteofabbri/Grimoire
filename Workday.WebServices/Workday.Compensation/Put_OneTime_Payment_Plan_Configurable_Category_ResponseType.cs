using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_One-Time_Payment_Plan_Configurable_Category_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_OneTime_Payment_Plan_Configurable_Category_ResponseType : INotifyPropertyChanged
	{
		private OneTime_Payment_Plan_Configurable_CategoryObjectType oneTime_Payment_Plan_Configurable_Category_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("One-Time_Payment_Plan_Configurable_Category_Reference", Order = 0)]
		public OneTime_Payment_Plan_Configurable_CategoryObjectType OneTime_Payment_Plan_Configurable_Category_Reference
		{
			get
			{
				return this.oneTime_Payment_Plan_Configurable_Category_ReferenceField;
			}
			set
			{
				this.oneTime_Payment_Plan_Configurable_Category_ReferenceField = value;
				this.RaisePropertyChanged("OneTime_Payment_Plan_Configurable_Category_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
