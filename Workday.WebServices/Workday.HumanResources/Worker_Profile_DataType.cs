using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Profile_DataType : INotifyPropertyChanged
	{
		private string itemField;

		private ItemChoiceType itemElementNameField;

		private string business_TitleField;

		private IDType[] integration_ID_DataField;

		private Worker_Status_DataType[] worker_Status_DataField;

		private Worker_Personal_DataType[] worker_Personal_DataField;

		private Worker_Position_DataType[] worker_Position_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Contingent_Worker_ID", typeof(string), Order = 0), XmlElement("Employee_ID", typeof(string), Order = 0)]
		public string Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 2)]
		public string Business_Title
		{
			get
			{
				return this.business_TitleField;
			}
			set
			{
				this.business_TitleField = value;
				this.RaisePropertyChanged("Business_Title");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement("Worker_Status_Data", Order = 4)]
		public Worker_Status_DataType[] Worker_Status_Data
		{
			get
			{
				return this.worker_Status_DataField;
			}
			set
			{
				this.worker_Status_DataField = value;
				this.RaisePropertyChanged("Worker_Status_Data");
			}
		}

		[XmlElement("Worker_Personal_Data", Order = 5)]
		public Worker_Personal_DataType[] Worker_Personal_Data
		{
			get
			{
				return this.worker_Personal_DataField;
			}
			set
			{
				this.worker_Personal_DataField = value;
				this.RaisePropertyChanged("Worker_Personal_Data");
			}
		}

		[XmlElement("Worker_Position_Data", Order = 6)]
		public Worker_Position_DataType[] Worker_Position_Data
		{
			get
			{
				return this.worker_Position_DataField;
			}
			set
			{
				this.worker_Position_DataField = value;
				this.RaisePropertyChanged("Worker_Position_Data");
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
