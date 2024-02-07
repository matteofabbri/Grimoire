using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Travel_City_Alternate_Name_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType spend_Data_Alternate_Name_ReferenceField;

		private string alternate_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Spend_Data_Alternate_Name_Reference
		{
			get
			{
				return this.spend_Data_Alternate_Name_ReferenceField;
			}
			set
			{
				this.spend_Data_Alternate_Name_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Data_Alternate_Name_Reference");
			}
		}

		[XmlElement(Order = 1)]
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
