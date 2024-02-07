using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Meeting_Action_Item_Sub_DataType : INotifyPropertyChanged
	{
		private Committee_Meeting_Action_ItemObjectType action_Item_ReferenceField;

		private string action_Item_IDField;

		private string itemField;

		private Committee_Member_EnabledObjectType[] assignee_ReferenceField;

		private string detailsField;

		private bool completeField;

		private bool completeFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Meeting_Action_ItemObjectType Action_Item_Reference
		{
			get
			{
				return this.action_Item_ReferenceField;
			}
			set
			{
				this.action_Item_ReferenceField = value;
				this.RaisePropertyChanged("Action_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Action_Item_ID
		{
			get
			{
				return this.action_Item_IDField;
			}
			set
			{
				this.action_Item_IDField = value;
				this.RaisePropertyChanged("Action_Item_ID");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Assignee_Reference", Order = 3)]
		public Committee_Member_EnabledObjectType[] Assignee_Reference
		{
			get
			{
				return this.assignee_ReferenceField;
			}
			set
			{
				this.assignee_ReferenceField = value;
				this.RaisePropertyChanged("Assignee_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Details
		{
			get
			{
				return this.detailsField;
			}
			set
			{
				this.detailsField = value;
				this.RaisePropertyChanged("Details");
			}
		}

		[XmlElement(Order = 5)]
		public bool Complete
		{
			get
			{
				return this.completeField;
			}
			set
			{
				this.completeField = value;
				this.RaisePropertyChanged("Complete");
			}
		}

		[XmlIgnore]
		public bool CompleteSpecified
		{
			get
			{
				return this.completeFieldSpecified;
			}
			set
			{
				this.completeFieldSpecified = value;
				this.RaisePropertyChanged("CompleteSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
