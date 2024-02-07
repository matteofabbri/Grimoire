using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Par_Count_Outbound_DataType : INotifyPropertyChanged
	{
		private string par_Count_IDField;

		private string document_NumberField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private DateTime count_DateField;

		private bool count_DateFieldSpecified;

		private LocationObjectType inventory_Par_Location_ReferenceField;

		private WorkerObjectType created_By_ReferenceField;

		private Inventory_Par_Count_Line_Outbound_DataType[] inventory_Par_Count_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Par_Count_ID
		{
			get
			{
				return this.par_Count_IDField;
			}
			set
			{
				this.par_Count_IDField = value;
				this.RaisePropertyChanged("Par_Count_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Document_Number
		{
			get
			{
				return this.document_NumberField;
			}
			set
			{
				this.document_NumberField = value;
				this.RaisePropertyChanged("Document_Number");
			}
		}

		[XmlElement(Order = 2)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Count_Date
		{
			get
			{
				return this.count_DateField;
			}
			set
			{
				this.count_DateField = value;
				this.RaisePropertyChanged("Count_Date");
			}
		}

		[XmlIgnore]
		public bool Count_DateSpecified
		{
			get
			{
				return this.count_DateFieldSpecified;
			}
			set
			{
				this.count_DateFieldSpecified = value;
				this.RaisePropertyChanged("Count_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public LocationObjectType Inventory_Par_Location_Reference
		{
			get
			{
				return this.inventory_Par_Location_ReferenceField;
			}
			set
			{
				this.inventory_Par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Par_Location_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public WorkerObjectType Created_By_Reference
		{
			get
			{
				return this.created_By_ReferenceField;
			}
			set
			{
				this.created_By_ReferenceField = value;
				this.RaisePropertyChanged("Created_By_Reference");
			}
		}

		[XmlElement("Inventory_Par_Count_Line_Data", Order = 6)]
		public Inventory_Par_Count_Line_Outbound_DataType[] Inventory_Par_Count_Line_Data
		{
			get
			{
				return this.inventory_Par_Count_Line_DataField;
			}
			set
			{
				this.inventory_Par_Count_Line_DataField = value;
				this.RaisePropertyChanged("Inventory_Par_Count_Line_Data");
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
