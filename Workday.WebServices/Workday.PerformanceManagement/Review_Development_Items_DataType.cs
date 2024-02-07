using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_Development_Items_DataType : INotifyPropertyChanged
	{
		private string development_Item_TitleField;

		private WorkerObjectType development_Item_Last_Updated_by_Worker_ReferenceField;

		private string additional_InformationField;

		private Development_Item_StatusObjectType status_ReferenceField;

		private DateTime last_Updated_DateField;

		private bool last_Updated_DateFieldSpecified;

		private Talent_TagObjectType[] tag_ReferenceField;

		private string status_NoteField;

		private Development_ItemObjectType development_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Development_Item_Title
		{
			get
			{
				return this.development_Item_TitleField;
			}
			set
			{
				this.development_Item_TitleField = value;
				this.RaisePropertyChanged("Development_Item_Title");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Development_Item_Last_Updated_by_Worker_Reference
		{
			get
			{
				return this.development_Item_Last_Updated_by_Worker_ReferenceField;
			}
			set
			{
				this.development_Item_Last_Updated_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Development_Item_Last_Updated_by_Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Additional_Information
		{
			get
			{
				return this.additional_InformationField;
			}
			set
			{
				this.additional_InformationField = value;
				this.RaisePropertyChanged("Additional_Information");
			}
		}

		[XmlElement(Order = 3)]
		public Development_Item_StatusObjectType Status_Reference
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

		[XmlElement(Order = 4)]
		public DateTime Last_Updated_Date
		{
			get
			{
				return this.last_Updated_DateField;
			}
			set
			{
				this.last_Updated_DateField = value;
				this.RaisePropertyChanged("Last_Updated_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Updated_DateSpecified
		{
			get
			{
				return this.last_Updated_DateFieldSpecified;
			}
			set
			{
				this.last_Updated_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Updated_DateSpecified");
			}
		}

		[XmlElement("Tag_Reference", Order = 5)]
		public Talent_TagObjectType[] Tag_Reference
		{
			get
			{
				return this.tag_ReferenceField;
			}
			set
			{
				this.tag_ReferenceField = value;
				this.RaisePropertyChanged("Tag_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Status_Note
		{
			get
			{
				return this.status_NoteField;
			}
			set
			{
				this.status_NoteField = value;
				this.RaisePropertyChanged("Status_Note");
			}
		}

		[XmlElement(Order = 7)]
		public Development_ItemObjectType Development_Item_Reference
		{
			get
			{
				return this.development_Item_ReferenceField;
			}
			set
			{
				this.development_Item_ReferenceField = value;
				this.RaisePropertyChanged("Development_Item_Reference");
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
