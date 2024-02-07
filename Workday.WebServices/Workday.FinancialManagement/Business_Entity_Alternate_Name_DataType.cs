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
	public class Business_Entity_Alternate_Name_DataType : INotifyPropertyChanged
	{
		private string alternate_NameField;

		private Alternate_Name_UsageObjectType[] alternate_Name_Usage_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Alternate_Name
		{
			get
			{
				return this.alternate_NameField;
			}
			set
			{
				this.alternate_NameField = value;
				this.RaisePropertyChanged("Alternate_Name");
			}
		}

		[XmlElement("Alternate_Name_Usage_Reference", Order = 1)]
		public Alternate_Name_UsageObjectType[] Alternate_Name_Usage_Reference
		{
			get
			{
				return this.alternate_Name_Usage_ReferenceField;
			}
			set
			{
				this.alternate_Name_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Name_Usage_Reference");
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
