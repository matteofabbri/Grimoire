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
	public class Development_Item_Version_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string development_ItemField;

		private string additional_InformationField;

		private Development_Item_StatusObjectType status_ReferenceField;

		private string status_NoteField;

		private WorkerObjectType updated_by_Worker_ReferenceField;

		private Talent_TagObjectType[] relates_To_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Development_Item
		{
			get
			{
				return this.development_ItemField;
			}
			set
			{
				this.development_ItemField = value;
				this.RaisePropertyChanged("Development_Item");
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

		[XmlElement(Order = 5)]
		public WorkerObjectType Updated_by_Worker_Reference
		{
			get
			{
				return this.updated_by_Worker_ReferenceField;
			}
			set
			{
				this.updated_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Updated_by_Worker_Reference");
			}
		}

		[XmlElement("Relates_To_Reference", Order = 6)]
		public Talent_TagObjectType[] Relates_To_Reference
		{
			get
			{
				return this.relates_To_ReferenceField;
			}
			set
			{
				this.relates_To_ReferenceField = value;
				this.RaisePropertyChanged("Relates_To_Reference");
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
