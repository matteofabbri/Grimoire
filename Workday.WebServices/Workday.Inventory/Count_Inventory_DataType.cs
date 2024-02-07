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
	public class Count_Inventory_DataType : INotifyPropertyChanged
	{
		private string count_Sheet_IDField;

		private LocationObjectType inventory_Site_ReferenceField;

		private WorkerObjectType assigned_To_ReferenceField;

		private string memoField;

		private Count_Inventory_Line_DataType[] count_Inventory_line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Count_Sheet_ID
		{
			get
			{
				return this.count_Sheet_IDField;
			}
			set
			{
				this.count_Sheet_IDField = value;
				this.RaisePropertyChanged("Count_Sheet_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Count_Inventory_line_Data", Order = 4)]
		public Count_Inventory_Line_DataType[] Count_Inventory_line_Data
		{
			get
			{
				return this.count_Inventory_line_DataField;
			}
			set
			{
				this.count_Inventory_line_DataField = value;
				this.RaisePropertyChanged("Count_Inventory_line_Data");
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
