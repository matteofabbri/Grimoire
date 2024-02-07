using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Skill_Item_Category_ResponseType : INotifyPropertyChanged
	{
		private Skill_Item_CategoryObjectType category_ReferenceField;

		private string nameField;

		private string idField;

		private Skill_ItemObjectType[] skill_Item_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Skill_Item_CategoryObjectType Category_Reference
		{
			get
			{
				return this.category_ReferenceField;
			}
			set
			{
				this.category_ReferenceField = value;
				this.RaisePropertyChanged("Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Skill_Item_Reference", Order = 3)]
		public Skill_ItemObjectType[] Skill_Item_Reference
		{
			get
			{
				return this.skill_Item_ReferenceField;
			}
			set
			{
				this.skill_Item_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Item_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
