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
	public class Integration_Transaction_Log_Configuration_DataType : INotifyPropertyChanged
	{
		private object[] itemsField;

		private ItemsChoiceType[] itemsElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemsElementName"), XmlElement("All_Business_Processes", typeof(bool), Order = 0), XmlElement("All_Transaction_Types", typeof(bool), Order = 0), XmlElement("Excluded_Business_Process_Type_Reference", typeof(Business_Process_TypeObjectType), Order = 0), XmlElement("Excluded_Transaction_Log_Type_Reference", typeof(Transaction_Log_TypeObjectType), Order = 0), XmlElement("Included_Transaction_Log_Type_Reference", typeof(Transaction_Log_TypeObjectType), Order = 0)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement("ItemsElementName", Order = 1), XmlIgnore]
		public ItemsChoiceType[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
				this.RaisePropertyChanged("ItemsElementName");
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
