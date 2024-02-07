using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Roles_Role_Assignment_DataType : INotifyPropertyChanged
	{
		private Role_AssignerObjectType role_Assigner_ReferenceField;

		private Assignable_RoleObjectType assignable_Role_ReferenceField;

		private bool remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerField;

		private bool remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerFieldSpecified;

		private bool update_Later_Dated_AssignmentsField;

		private bool update_Later_Dated_AssignmentsFieldSpecified;

		private Rolee_SelectorObjectType[] assignees_to_Add_ReferenceField;

		private Rolee_SelectorObjectType[] assignees_to_Remove_ReferenceField;

		private Rolee_SelectorObjectType supervisory_Organization_Single_Assignment_Manager_ReferenceField;

		private bool remove_Supervisory_Organization_Single_Assignment_ManagerField;

		private bool remove_Supervisory_Organization_Single_Assignment_ManagerFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Role_AssignerObjectType Role_Assigner_Reference
		{
			get
			{
				return this.role_Assigner_ReferenceField;
			}
			set
			{
				this.role_Assigner_ReferenceField = value;
				this.RaisePropertyChanged("Role_Assigner_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Assignable_RoleObjectType Assignable_Role_Reference
		{
			get
			{
				return this.assignable_Role_ReferenceField;
			}
			set
			{
				this.assignable_Role_ReferenceField = value;
				this.RaisePropertyChanged("Assignable_Role_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Remove_Existing_Assignees_for_Assignable_Role_on_Role_Assigner
		{
			get
			{
				return this.remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerField;
			}
			set
			{
				this.remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerField = value;
				this.RaisePropertyChanged("Remove_Existing_Assignees_for_Assignable_Role_on_Role_Assigner");
			}
		}

		[XmlIgnore]
		public bool Remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerSpecified
		{
			get
			{
				return this.remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerFieldSpecified;
			}
			set
			{
				this.remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Existing_Assignees_for_Assignable_Role_on_Role_AssignerSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Update_Later_Dated_Assignments
		{
			get
			{
				return this.update_Later_Dated_AssignmentsField;
			}
			set
			{
				this.update_Later_Dated_AssignmentsField = value;
				this.RaisePropertyChanged("Update_Later_Dated_Assignments");
			}
		}

		[XmlIgnore]
		public bool Update_Later_Dated_AssignmentsSpecified
		{
			get
			{
				return this.update_Later_Dated_AssignmentsFieldSpecified;
			}
			set
			{
				this.update_Later_Dated_AssignmentsFieldSpecified = value;
				this.RaisePropertyChanged("Update_Later_Dated_AssignmentsSpecified");
			}
		}

		[XmlElement("Assignees_to_Add_Reference", Order = 4)]
		public Rolee_SelectorObjectType[] Assignees_to_Add_Reference
		{
			get
			{
				return this.assignees_to_Add_ReferenceField;
			}
			set
			{
				this.assignees_to_Add_ReferenceField = value;
				this.RaisePropertyChanged("Assignees_to_Add_Reference");
			}
		}

		[XmlElement("Assignees_to_Remove_Reference", Order = 5)]
		public Rolee_SelectorObjectType[] Assignees_to_Remove_Reference
		{
			get
			{
				return this.assignees_to_Remove_ReferenceField;
			}
			set
			{
				this.assignees_to_Remove_ReferenceField = value;
				this.RaisePropertyChanged("Assignees_to_Remove_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Rolee_SelectorObjectType Supervisory_Organization_Single_Assignment_Manager_Reference
		{
			get
			{
				return this.supervisory_Organization_Single_Assignment_Manager_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_Single_Assignment_Manager_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Single_Assignment_Manager_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Remove_Supervisory_Organization_Single_Assignment_Manager
		{
			get
			{
				return this.remove_Supervisory_Organization_Single_Assignment_ManagerField;
			}
			set
			{
				this.remove_Supervisory_Organization_Single_Assignment_ManagerField = value;
				this.RaisePropertyChanged("Remove_Supervisory_Organization_Single_Assignment_Manager");
			}
		}

		[XmlIgnore]
		public bool Remove_Supervisory_Organization_Single_Assignment_ManagerSpecified
		{
			get
			{
				return this.remove_Supervisory_Organization_Single_Assignment_ManagerFieldSpecified;
			}
			set
			{
				this.remove_Supervisory_Organization_Single_Assignment_ManagerFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Supervisory_Organization_Single_Assignment_ManagerSpecified");
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
