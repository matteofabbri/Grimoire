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
	public class Inventory_Count_Sheet_DataType : INotifyPropertyChanged
	{
		private string count_SheetField;

		private Document_StatusObjectType status_ReferenceField;

		private DateTime created_OnField;

		private bool created_OnFieldSpecified;

		private LocationObjectType inventory_Site_ReferenceField;

		private WorkerObjectType assigned_To_ReferenceField;

		private Inventory_Adjustment_ReasonObjectType adjustment_Reason_ReferenceField;

		private string memoField;

		private Inventory_Count_Sheet_Line_DataType[] inventory_Count_Sheet_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Count_Sheet
		{
			get
			{
				return this.count_SheetField;
			}
			set
			{
				this.count_SheetField = value;
				this.RaisePropertyChanged("Count_Sheet");
			}
		}

		[XmlElement(Order = 1)]
		public Document_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Created_On
		{
			get
			{
				return this.created_OnField;
			}
			set
			{
				this.created_OnField = value;
				this.RaisePropertyChanged("Created_On");
			}
		}

		[XmlIgnore]
		public bool Created_OnSpecified
		{
			get
			{
				return this.created_OnFieldSpecified;
			}
			set
			{
				this.created_OnFieldSpecified = value;
				this.RaisePropertyChanged("Created_OnSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public WorkerObjectType Assigned_To_Reference
		{
			get
			{
				return this.assigned_To_ReferenceField;
			}
			set
			{
				this.assigned_To_ReferenceField = value;
				this.RaisePropertyChanged("Assigned_To_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Inventory_Adjustment_ReasonObjectType Adjustment_Reason_Reference
		{
			get
			{
				return this.adjustment_Reason_ReferenceField;
			}
			set
			{
				this.adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Adjustment_Reason_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Inventory_Count_Sheet_Line_Data", Order = 7)]
		public Inventory_Count_Sheet_Line_DataType[] Inventory_Count_Sheet_Line_Data
		{
			get
			{
				return this.inventory_Count_Sheet_Line_DataField;
			}
			set
			{
				this.inventory_Count_Sheet_Line_DataField = value;
				this.RaisePropertyChanged("Inventory_Count_Sheet_Line_Data");
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
